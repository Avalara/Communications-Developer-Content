# RestDemoApplication

## Geo Batch Api Test Tab

### Geo Batch is tool that can be used to Geocode a large sample of Addresses or Lat Long coordinates

Geo Batch can be used by either **API** or **Comms Platform** (<https://communicationsua.avalara.net/AFC/GeoBatch)>

### Step 1: Create a .csv file with the following:

- Required Headers (Address File):
  - ![Address Headers](https://help.avalara.com/@api/deki/files/29120/clipboard_e84de000ec8bf467cfaa3b10052c871b2.png?revision=1)
- Required Headers (Lat/Long File):
  - ![Lat/Long Headers](https://help.avalara.com/@api/deki/files/29119/clipboard_e2ccd128bcff0508be48d954327345ce0.png?revision=1)
- Please delete any blank rows
- Do not use commas in any field
- Sample files can be found here: <https://communicationsua.avalara.net/downloads/GeoBatchSamples.zip>

### Step 2 - Option A: Geo Batch Online

- To upload the .csv file to <https://communicationsua.avalara.net/AFC/GeoBatch>
  - Log into Comms Platform and navigate to Geo Batch by clicking the link above
  - Verify that you are using the client "TEST"
  - Select "Add New Record"
  - Select "Choose File" and open the .csv file from Step 1
  - Submit the file to Geo Batch
  - Once your file receives the "Completed" status, you may download the Output File

### Step 2 - Option B: Geo Batch API

- Geo Batch offers an API to upload files as well
  - Run the RestDemoApplication from inside the attached repository
  - Navigate to the "Geo Batch" tab
  - Enter your credentials in the head of the application and select the appropriate Client ID
  - Click the "Upload Request File" button and select the .csv from Step 1
  - In the response field, you will receive a ProcessId, this is your key to accessing information on the uploaded file
  - The ProcessID will also automatically populate the ProcessID text box
    - To view the status of the file, click the "Get File Status" button
    - To view the logs of the file, click the "Get File Logs" button
  - To retrieve your input file download, click the "Download Input File" button or copy the "InputFileDownload" from the response and paste into a browser
  - To retrieve your output file download, click the "Download Output File" button or copy the "OutputFileDownload" from the response and paste into a browser
    - Note: These buttons will not appear until the respective files are ready!

[Parent](../README.md)
