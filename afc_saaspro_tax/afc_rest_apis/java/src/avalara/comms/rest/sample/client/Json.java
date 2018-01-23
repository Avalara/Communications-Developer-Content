package avalara.comms.rest.sample.client;

import com.google.gson.Gson;
import com.google.gson.GsonBuilder;
import com.google.gson.JsonParseException;
import com.google.gson.TypeAdapter;
import com.google.gson.stream.JsonReader;
import com.google.gson.stream.JsonToken;
import com.google.gson.stream.JsonWriter;
import java.io.IOException;
import java.io.StringReader;
import java.lang.reflect.Type;
import java.time.LocalDate;
import java.time.LocalDateTime;
import java.time.format.DateTimeFormatter;

/**
 * Class used for serializing and de-serializing objects to JSON.
 */
public class Json {
    private final Gson gson;

    /**
     * Constructor.
     */
    public Json() {
        gson = new GsonBuilder()
            .setPrettyPrinting()
            .registerTypeAdapter(LocalDate.class, new LocalDateTypeAdapter())
            .registerTypeAdapter(LocalDateTime.class, new LocalDateTimeTypeAdapter())
            .create();
    }

    /**
     * Serialize the given Java object into JSON string.
     *
     * @param obj Object to serialize.
     * @return JSON string representation of the object.
     */
    public String serialize(Object obj) {
        return gson.toJson(obj);
    }

    /**
     * De-serialize the given JSON string to Java object.
     *
     * @param <T>           Type for de-serialized object.
     * @param body          JSON string to de-serialize
     * @param returnType    Type for de-serialized object.
     * @return De-serialized Java object from JSON string.
     */
    @SuppressWarnings("unchecked")
    public <T> T deserialize(String body, Type returnType) {
        try {
            JsonReader jsonReader = new JsonReader(new StringReader(body));
            jsonReader.setLenient(true);
            return gson.fromJson(jsonReader, returnType);
        } 
        catch (JsonParseException e) {
            // Fallback processing when failed to parse JSON form response body:
            // return the response body string directly for the String return type.
            if (returnType.equals(String.class))
                return (T) body;
            else throw(e);
        }
    }
}

/**
 * TypeAdapter for java.time.LocalDate type.
 */
class LocalDateTypeAdapter extends TypeAdapter<LocalDate> {

    private final DateTimeFormatter formatter = DateTimeFormatter.ofPattern("yyyy-MM-dd'T'HH:mm:ss'Z'");

    /**
     * Serializes the LocalDate object to a string.
     * 
     * @param out   JsonWriter object.
     * @param date  LocalDate object.
     * @throws IOException 
     */
    @Override
    public void write(JsonWriter out, LocalDate date) throws IOException {
        if (date == null) {
            out.nullValue();
        } else {
            out.value(date.format(formatter));
        }
    }

    /**
     * De-serializes a JSON attribute into a LocalDate object.
     * 
     * @param in JsonReader object.
     * @return De-serialized LocalDateTime object.
     * @throws IOException 
     */
    @Override
    public LocalDate read(JsonReader in) throws IOException {
        if (in.peek() == JsonToken.NULL) {
            in.nextNull();
            return null;
        }
        
        String date = in.nextString();
        
        if (date.startsWith("\""))
            date = date.substring(1);

        if (date.endsWith("\""))
            date = date.substring(0, date.length() - 2);

        return LocalDate.parse(date.subSequence(0, date.length() - 1), formatter);
    }
}

/**
 * TypeAdapter for java.time.LocalDateTime type.
 */
class LocalDateTimeTypeAdapter extends TypeAdapter<LocalDateTime> {

    private final DateTimeFormatter formatter = DateTimeFormatter.ofPattern("yyyy-MM-dd'T'HH:mm:ss.n'Z'");

    /**
     * Serializes the LocalDateTime object to a string.
     * 
     * @param out   JsonWriter object.
     * @param date  LocalDate object.
     * @throws IOException 
     */
    @Override
    public void write(JsonWriter out, LocalDateTime date) throws IOException {
        if (date == null) {
            out.nullValue();
        } else {
            out.value(date.format(formatter));
        }
    }

    /**
     * De-serializes a JSON attribute into a LocalDateTime object.
     * 
     * @param in JsonReader object.
     * @return De-serialized LocalDateTime object.
     * @throws IOException 
     */
    @Override
    public LocalDateTime read(JsonReader in) throws IOException {
        if (in.peek() == JsonToken.NULL) {
            in.nextNull();
            return null;
        }
        
        String date = in.nextString();
        CharSequence charSeq = date.subSequence(0, date.length());
        return LocalDateTime.parse(charSeq, formatter);
    }
}
