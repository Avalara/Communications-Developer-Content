using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TelecomSampleApplication.EZTaxWebService;
using System.Xml.Serialization;
using System.IO;

namespace TelecomSampleApplication
{
    public delegate void UpdateTextBoxText(bool isError, string s);

    public partial class TelecomForm : Form
    {
        #region Delegates
        public EventHandler      RunDEL;
        public EventHandler      DoneDEL;
        public UpdateTextBoxText UpdateTextBoxTextDEL;
        #endregion

        #region Data Declarations
        private string TheUserName = "";
        private string ThePassword = "";
        #endregion

        #region Constructor
        public TelecomForm () 
        {
            InitializeComponent();

            RunDEL               = new EventHandler(RunDelegate);
            DoneDEL              = new EventHandler(DoneDelegate);
            UpdateTextBoxTextDEL = new UpdateTextBoxText(UpdateTextBoxTextDelegate);
        }
        #endregion

        #region Event Methods
        private void RunSampleBTN_Click (object sender, EventArgs e) 
        {
            TheUserName = UserNameTB.Text;
            ThePassword = PasswordTB.Text;

            UserNameTB  .Enabled = false;
            PasswordTB  .Enabled = false;
            RunSampleBTN.Enabled = false;
            ResultsTB   .Enabled = false;

            RunDEL.BeginInvoke(this, EventArgs.Empty, null, null);
        }
        #endregion

        #region Delegate Methods
        private void RunDelegate               (object sender, EventArgs e) 
        {
            //Using the Faster Basic Binding.  It utilizes https for security.
            using (EZTaxWebServiceClient TheClient = new EZTaxWebServiceClient("BasicHttpBinding_IEZTaxWebService"))
            {
                try
                {
                    StringBuilder TheResultStringBuilder = new StringBuilder();
                    string        TheSpacer              = "          ";

                    //Setup Sample Parameters
                    uint       ThePCode      = 2146200;
                    int        TheTaxType    = 1;
                    uint       TheNpaNxx     = 660826;
                    string     TheFIPS       = "2915966440";
                    ZipAddress TheZipAddress = new ZipAddress()
                    {
                        CountryISO = "USA",
                        State      = "MO",
                        County     = "Pettis",
                        Locality   = "Sedalia",
                        ZipCode    = "65301"
                    };
                    Transaction TheTransaction = new Transaction()
                    {
                        AdjustmentMethod   = 0,
                        CustomerType       = 0,
                        DiscountType       = 0,
                        ServiceClass       = 0,
                        Date               = DateTime.Today,
                        BusinessClass      = 0,
                        Sale               = true,
                        Regulated          = true,
                        Charge             = 100,
                        Minutes            = 5.3,
                        Lines              = 3,
                        Locations          = 1,
                        Incorporated       = true,
                        FederalExempt      = false,
                        StateExempt        = false,
                        CountyExempt       = false,
                        LocalExempt        = false,
                        FederalPCode       = 0,
                        StatePCode         = 0,
                        CountyPCode        = 0,
                        LocalPCode         = 0,
                        InvoiceNumber      = 3,
                        ServiceLevelNumber = 4,
                        CustomerNumber     = "EZTaxWebService",
                        TransactionType    = 13,
                        ServiceType        = 6,
                        Debit              = false
                    };

                    //Setting Username and Password to access service
                    TheClient.ClientCredentials.UserName.UserName = TheUserName;
                    TheClient.ClientCredentials.UserName.Password = ThePassword;

                    #region Sample Method: GetAddress

                    AddressData[] TheGetAddressResult = TheClient.GetAddress(ThePCode);

                    TheResultStringBuilder.Append("****GetAddress Called with PCode=" + ThePCode + "\r\n");

                    //No Addresses Found
                    if (TheGetAddressResult == null)
                    {
                        TheResultStringBuilder.Append(TheSpacer + "NO RESULTS");
                    }
                    else
                    {
                        TheResultStringBuilder.Append(TheSpacer + SerializeToXml<AddressData[]>(TheGetAddressResult).Replace("\r\n", "\r\n" + TheSpacer));
                    }

                    TheResultStringBuilder.Append("\r\n\r\n");

                    UpdateTextBoxTextDEL.Invoke(false, TheResultStringBuilder.ToString());

                    #endregion

                    #region Sample Method: PCodeToFips

                    TheResultStringBuilder = new StringBuilder();

                    string ThePCodeToFipsResult = TheClient.PCodeToFips(ThePCode);

                    TheResultStringBuilder.Append("****PCodeToFips Called with PCode=" + ThePCode + "\r\n");

                    //No Fips Code Found
                    if (string.IsNullOrEmpty(ThePCodeToFipsResult))
                    {
                        TheResultStringBuilder.Append(TheSpacer + "NO RESULT");
                    }
                    else
                    {
                        TheResultStringBuilder.Append(TheSpacer + SerializeToXml<string>(ThePCodeToFipsResult).Replace("\r\n", "\r\n" + TheSpacer));
                    }

                    UpdateTextBoxTextDEL.Invoke(false, TheResultStringBuilder.ToString());

                    #endregion

                    #region Sample Method: GetTaxCategory

                    TheResultStringBuilder = new StringBuilder();

                    string TheGetTaxCategoryResult = TheClient.GetTaxCategory(TheTaxType);

                    TheResultStringBuilder.Append("\r\n\r\n");
                    TheResultStringBuilder.Append("****GetTaxCategory Called with TaxType=" + TheTaxType + "\r\n");

                    //No Tax Category Found
                    if (string.IsNullOrEmpty(TheGetTaxCategoryResult))
                    {
                        TheResultStringBuilder.Append(TheSpacer + "NO RESULT");
                    }
                    else
                    {
                        TheResultStringBuilder.Append(TheSpacer + SerializeToXml<string>(TheGetTaxCategoryResult).Replace("\r\n", "\r\n" + TheSpacer));
                    }

                    UpdateTextBoxTextDEL.Invoke(false, TheResultStringBuilder.ToString());

                    #endregion

                    #region Sample Method: GetTaxDescription

                    TheResultStringBuilder = new StringBuilder();

                    string TheGetTaxDescriptionResult = TheClient.GetTaxDescription(TheTaxType);

                    TheResultStringBuilder.Append("\r\n\r\n");
                    TheResultStringBuilder.Append("****GetTaxDescription Called with TaxType=" + TheTaxType + "\r\n");

                    //No Tax Description Found
                    if (string.IsNullOrEmpty(TheGetTaxDescriptionResult))
                    {
                        TheResultStringBuilder.Append(TheSpacer + "NO RESULT");
                    }
                    else
                    {
                        TheResultStringBuilder.Append(TheSpacer + SerializeToXml<string>(TheGetTaxDescriptionResult).Replace("\r\n", "\r\n" + TheSpacer));
                    }

                    UpdateTextBoxTextDEL.Invoke(false, TheResultStringBuilder.ToString());

                    #endregion

                    #region Sample Method: NpaNxxToPCode

                    TheResultStringBuilder = new StringBuilder();

                    uint? TheNpaNxxToPCodeResult = TheClient.NpaNxxToPCode(TheNpaNxx);

                    TheResultStringBuilder.Append("\r\n\r\n");
                    TheResultStringBuilder.Append("****NpaNxxToPCode Called with FIPS=" + TheNpaNxx + "\r\n");

                    //No PCode Code Found
                    if (!TheNpaNxxToPCodeResult.HasValue)
                    {
                        TheResultStringBuilder.Append(TheSpacer + "NO RESULT");
                    }
                    else
                    {
                        TheResultStringBuilder.Append(TheSpacer + SerializeToXml<uint>(TheNpaNxxToPCodeResult.Value).Replace("\r\n", "\r\n" + TheSpacer));
                    }

                    UpdateTextBoxTextDEL.Invoke(false, TheResultStringBuilder.ToString());

                    #endregion

                    #region Sample Method: FipsToPCode

                    TheResultStringBuilder = new StringBuilder();

                    uint? TheFipsToPCodeResult = TheClient.FipsToPCode(TheFIPS);

                    TheResultStringBuilder.Append("\r\n\r\n");
                    TheResultStringBuilder.Append("****FipsToPCode Called with FIPS=" + TheFIPS + "\r\n");

                    //No PCode Code Found
                    if (!TheFipsToPCodeResult.HasValue)
                    {
                        TheResultStringBuilder.Append(TheSpacer + "NO RESULT");
                    }
                    else
                    {
                        TheResultStringBuilder.Append(TheSpacer + SerializeToXml<uint>(TheFipsToPCodeResult.Value).Replace("\r\n", "\r\n" + TheSpacer));
                    }

                    UpdateTextBoxTextDEL.Invoke(false, TheResultStringBuilder.ToString());

                    #endregion

                    #region Sample Method: ZipToPCode

                    TheResultStringBuilder = new StringBuilder();

                    uint? TheZipToPCodeResult = TheClient.ZipToPCode(TheZipAddress);

                    TheResultStringBuilder.Append("\r\n\r\n");
                    TheResultStringBuilder.Append("****ZipToPCode Called with ZipAddress=(See Code)\r\n");

                    //No PCode Code Found
                    if (!TheZipToPCodeResult.HasValue)
                    {
                        TheResultStringBuilder.Append(TheSpacer + "NO RESULT");
                    }
                    else
                    {
                        TheResultStringBuilder.Append(TheSpacer + SerializeToXml<uint>(TheZipToPCodeResult.Value).Replace("\r\n", "\r\n" + TheSpacer));
                    }

                    UpdateTextBoxTextDEL.Invoke(false, TheResultStringBuilder.ToString());

                    #endregion

                    #region Sample Method: GetServerTime

                    TheResultStringBuilder = new StringBuilder();

                    DateTime TheGetServerTimeResult = TheClient.GetServerTime();

                    TheResultStringBuilder.Append("\r\n\r\n");
                    TheResultStringBuilder.Append("****GetServerTime\r\n");
                    TheResultStringBuilder.Append(TheSpacer + SerializeToXml<DateTime>(TheGetServerTimeResult).Replace("\r\n", "\r\n" + TheSpacer));

                    UpdateTextBoxTextDEL.Invoke(false, TheResultStringBuilder.ToString());

                    #endregion

                    #region Sample Method: CalcTaxesWithPCode

                    TheResultStringBuilder = new StringBuilder();

                    //Set PCode for Transaction
                    TheTransaction.BillToPCode      = ThePCode;
                    TheTransaction.OriginationPCode = ThePCode;
                    TheTransaction.TerminationPCode = ThePCode;

                    TaxData[] TheCalcTaxesWithPCodeResult = TheClient.CalcTaxesWithPCode(TheTransaction);

                    TheResultStringBuilder.Append("\r\n\r\n");
                    TheResultStringBuilder.Append("****CalcTaxesWithPCode Called with Transaction=(See Code)\r\n");

                    if (TheCalcTaxesWithPCodeResult == null)
                    {
                        TheResultStringBuilder.Append(TheSpacer + "NO RESULT");
                    }
                    else
                    {
                        TheResultStringBuilder.Append(TheSpacer + SerializeToXml<TaxData[]>(TheCalcTaxesWithPCodeResult).Replace("\r\n", "\r\n" + TheSpacer));
                    }

                    UpdateTextBoxTextDEL.Invoke(false, TheResultStringBuilder.ToString());

                    #endregion

                    #region Sample Method: CalcTaxesWithFipsCode

                    TheResultStringBuilder = new StringBuilder();

                    //Set FipsCode for Transaction
                    TheTransaction.BillToFipsCode      = TheFIPS;
                    TheTransaction.OriginationFipsCode = TheFIPS;
                    TheTransaction.TerminationFipsCode = TheFIPS;

                    TaxData[] TheCalcTaxesWithFipsCodeResult = TheClient.CalcTaxesWithFipsCode(TheTransaction);

                    TheResultStringBuilder.Append("\r\n\r\n");
                    TheResultStringBuilder.Append("****CalcTaxesWithFipsCode Called with Transaction=(See Code)\r\n");

                    if (TheCalcTaxesWithFipsCodeResult == null)
                    {
                        TheResultStringBuilder.Append(TheSpacer + "NO RESULT");
                    }
                    else
                    {
                        TheResultStringBuilder.Append(TheSpacer + SerializeToXml<TaxData[]>(TheCalcTaxesWithFipsCodeResult).Replace("\r\n", "\r\n" + TheSpacer));
                    }

                    UpdateTextBoxTextDEL.Invoke(false, TheResultStringBuilder.ToString());

                    #endregion

                    #region Sample Method: CalcTaxesWithNpaNxx

                    TheResultStringBuilder = new StringBuilder();

                    //Set NpaNxx for Transaction
                    TheTransaction.BillToNpaNxx      = TheNpaNxx;
                    TheTransaction.OriginationNpaNxx = TheNpaNxx;
                    TheTransaction.TerminationNpaNxx = TheNpaNxx;

                    TaxData[] TheCalcTaxesWithNpaNxxResult = TheClient.CalcTaxesWithNpaNxx(TheTransaction);

                    TheResultStringBuilder.Append("\r\n\r\n");
                    TheResultStringBuilder.Append("****CalcTaxesWithNpaNxx Called with Transaction=(See Code)\r\n");

                    if (TheCalcTaxesWithNpaNxxResult == null)
                    {
                        TheResultStringBuilder.Append(TheSpacer + "NO RESULT");
                    }
                    else
                    {
                        TheResultStringBuilder.Append(TheSpacer + SerializeToXml<TaxData[]>(TheCalcTaxesWithNpaNxxResult).Replace("\r\n", "\r\n" + TheSpacer));
                    }

                    UpdateTextBoxTextDEL.Invoke(false, TheResultStringBuilder.ToString());

                    #endregion

                    #region Sample Method: CalcTaxesWithZipAddress

                    TheResultStringBuilder = new StringBuilder();

                    //Set ZipAddress for Transaction
                    TheTransaction.BillToAddress      = TheZipAddress;
                    TheTransaction.OriginationAddress = TheZipAddress;
                    TheTransaction.TerminationAddress = TheZipAddress;

                    TaxData[] TheCalcTaxesWithZipAddressResult = TheClient.CalcTaxesWithZipAddress(TheTransaction);

                    TheResultStringBuilder.Append("\r\n\r\n");
                    TheResultStringBuilder.Append("****CalcTaxesWithZipAddress Called with Transaction=(See Code)\r\n");

                    if (TheCalcTaxesWithZipAddressResult == null)
                    {
                        TheResultStringBuilder.Append(TheSpacer + "NO RESULT");
                    }
                    else
                    {
                        TheResultStringBuilder.Append(TheSpacer + SerializeToXml<TaxData[]>(TheCalcTaxesWithZipAddressResult).Replace("\r\n", "\r\n" + TheSpacer));
                    }

                    UpdateTextBoxTextDEL.Invoke(false, TheResultStringBuilder.ToString());

                    #endregion

                    #region Sample Method: CalcAdjWithPCode

                    TheResultStringBuilder = new StringBuilder();

                    //Set PCode for Transaction
                    TheTransaction.BillToPCode      = ThePCode;
                    TheTransaction.OriginationPCode = ThePCode;
                    TheTransaction.TerminationPCode = ThePCode;

                    TaxData[] TheCalcAdjWithPCodeResult = TheClient.CalcAdjWithPCode(TheTransaction);

                    TheResultStringBuilder.Append("\r\n\r\n");
                    TheResultStringBuilder.Append("****CalcAdjWithPCode Called with Transaction=(See Code)\r\n");

                    if (TheCalcAdjWithPCodeResult == null)
                    {
                        TheResultStringBuilder.Append(TheSpacer + "NO RESULT");
                    }
                    else
                    {
                        TheResultStringBuilder.Append(TheSpacer + SerializeToXml<TaxData[]>(TheCalcAdjWithPCodeResult).Replace("\r\n", "\r\n" + TheSpacer));
                    }

                    UpdateTextBoxTextDEL.Invoke(false, TheResultStringBuilder.ToString());

                    #endregion

                    #region Sample Method: CalcTaxesWithFipsCode

                    TheResultStringBuilder = new StringBuilder();

                    //Set FipsCode for Transaction
                    TheTransaction.BillToFipsCode = TheFIPS;
                    TheTransaction.OriginationFipsCode = TheFIPS;
                    TheTransaction.TerminationFipsCode = TheFIPS;

                    TaxData[] TheCalcAdjWithFipsCodeResult = TheClient.CalcAdjWithFipsCode(TheTransaction);

                    TheResultStringBuilder.Append("\r\n\r\n");
                    TheResultStringBuilder.Append("****CalcAdjWithFipsCode Called with Transaction=(See Code)\r\n");

                    if (TheCalcAdjWithFipsCodeResult == null)
                    {
                        TheResultStringBuilder.Append(TheSpacer + "NO RESULT");
                    }
                    else
                    {
                        TheResultStringBuilder.Append(TheSpacer + SerializeToXml<TaxData[]>(TheCalcAdjWithFipsCodeResult).Replace("\r\n", "\r\n" + TheSpacer));
                    }

                    UpdateTextBoxTextDEL.Invoke(false, TheResultStringBuilder.ToString());

                    #endregion

                    #region Sample Method: CalcAdjWithNpaNxx

                    TheResultStringBuilder = new StringBuilder();

                    //Set NpaNxx for Transaction
                    TheTransaction.BillToNpaNxx      = TheNpaNxx;
                    TheTransaction.OriginationNpaNxx = TheNpaNxx;
                    TheTransaction.TerminationNpaNxx = TheNpaNxx;

                    TaxData[] TheCalcAdjWithNpaNxxResult = TheClient.CalcAdjWithNpaNxx(TheTransaction);

                    TheResultStringBuilder.Append("\r\n\r\n");
                    TheResultStringBuilder.Append("****CalcAdjWithNpaNxx Called with Transaction=(See Code)\r\n");

                    if (TheCalcAdjWithNpaNxxResult == null)
                    {
                        TheResultStringBuilder.Append(TheSpacer + "NO RESULT");
                    }
                    else
                    {
                        TheResultStringBuilder.Append(TheSpacer + SerializeToXml<TaxData[]>(TheCalcAdjWithNpaNxxResult).Replace("\r\n", "\r\n" + TheSpacer));
                    }

                    UpdateTextBoxTextDEL.Invoke(false, TheResultStringBuilder.ToString());

                    #endregion

                    #region Sample Method: CalcAdjWithZipAddress

                    TheResultStringBuilder = new StringBuilder();

                    //Set PCode for Transaction
                    TheTransaction.BillToAddress      = TheZipAddress;
                    TheTransaction.OriginationAddress = TheZipAddress;
                    TheTransaction.TerminationAddress = TheZipAddress;

                    TaxData[] TheCalcAdjWithZipAddressResult = TheClient.CalcAdjWithZipAddress(TheTransaction);

                    TheResultStringBuilder.Append("\r\n\r\n");
                    TheResultStringBuilder.Append("****CalcAdjWithZipAddress Called with Transaction=(See Code)\r\n");

                    //No NpaNxx Code Found
                    if (TheCalcAdjWithZipAddressResult == null)
                    {
                        TheResultStringBuilder.Append(TheSpacer + "NO RESULT");
                    }
                    else
                    {
                        TheResultStringBuilder.Append(TheSpacer + SerializeToXml<TaxData[]>(TheCalcAdjWithZipAddressResult).Replace("\r\n", "\r\n" + TheSpacer));
                    }

                    UpdateTextBoxTextDEL.Invoke(false, TheResultStringBuilder.ToString());

                    #endregion
                }
                catch (Exception ex)
                {
                    UpdateTextBoxTextDelegate(true, ex.ToString());
                }
            }

            DoneDEL.Invoke(this, EventArgs.Empty);
        }
        private void DoneDelegate              (object sender, EventArgs e) 
        {
            if (ResultsTB.InvokeRequired)
            {
                ResultsTB.Invoke(new EventHandler(DoneDelegate), new object[] { sender, e });
            }
            else
            {
                UserNameTB  .Enabled = true;
                PasswordTB  .Enabled = true;
                RunSampleBTN.Enabled = true;
                ResultsTB   .Enabled = true;
            }
        }
        private void UpdateTextBoxTextDelegate (bool isError, string s)     
        {
            if (ResultsTB.InvokeRequired)
            {
                ResultsTB.Invoke(new UpdateTextBoxText(UpdateTextBoxTextDelegate), new object[] { isError, s });
            }
            else
            {
                if (isError)
                {
                    MessageBox.Show(s);
                    ResultsTB.Text = ResultsTB.Text + "\r\n\r\n" + s;
                }
                else
                {
                    ResultsTB.Text = ResultsTB.Text + s;
                }
            }
        }
        #endregion

        #region Helper Methods
        private string SerializeToXml<T> (T anObject) 
        {
            XmlSerializer TheXmlSerializer = new XmlSerializer(anObject.GetType());
            MemoryStream  TheMemoryStream  = new MemoryStream();

            TheXmlSerializer.Serialize(TheMemoryStream, anObject);

            return Encoding.UTF8.GetString(TheMemoryStream.GetBuffer());
        }
        #endregion
    }
}
