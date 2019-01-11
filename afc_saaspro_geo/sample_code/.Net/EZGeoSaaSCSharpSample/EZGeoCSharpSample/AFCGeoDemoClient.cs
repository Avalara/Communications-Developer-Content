using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ServiceModel;

namespace EZGeoCSharpSample
{
    public partial class AFCGeoDemoClient : Form
    {
        Boolean updateServiceCredentials;
        EZGeoSaaS.LocatorServiceClient ezgeoServiceClient = null;

        public AFCGeoDemoClient()
        {
            InitializeComponent();
        }

        private void btnGetServerTime_Click(object sender, EventArgs e)
        {
            if (updateServiceCredentials)
            {
                SetServiceCredentials(txtUserName.Text, txtPassword.Text);
            }
            try
            {
                this.txtServerTime.Text = ezgeoServiceClient.GetServerTime();
            }
            catch(FaultException<EZGeoSaaS.EZGeoFault> fx)
            {
                MessageBox.Show(fx.Message, "Service Request Failed", MessageBoxButtons.OK);
                ClearFaultedState();                    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Service Request Failed", MessageBoxButtons.OK);
                ClearFaultedState();
            }

        }

        private void btnVerifyAddress_Click(object sender, EventArgs e)
        {
            ClearResultFields();
            var restoreCursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;

            if (String.IsNullOrEmpty(txtStreet.Text) || String.IsNullOrEmpty(txtCityStateZip.Text))
            {
                MessageBox.Show("Street and CityStateZip input required.",
                    "Invalid input data", MessageBoxButtons.OK);
                return;
            }

            if (updateServiceCredentials)
            {
                SetServiceCredentials(txtUserName.Text, txtPassword.Text);
            }

            EZGeoSaaS.AddressLocation addressLocation = null;
            EZGeoSaaS.InputAddress inputAddress = GetInputAddress();

            try
            {
                addressLocation = ezgeoServiceClient.GeocodeAddress(inputAddress);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Service Request Failed", MessageBoxButtons.OK);
                ClearFaultedState();
            }

            if (addressLocation != null)
            {
                DisplayGeocodeResult(addressLocation);
            }
            else
            {
                txtScore.Text = "0.0";
                txtGeocodedStreet.Text = "Address not found";
            }

            Cursor.Current = restoreCursor;

        }

        private void ClearFaultedState()
        {
            try
            {
                ezgeoServiceClient.Abort();
            }
            catch (Exception)
            {
                //Ignore
            }

            if (!String.IsNullOrEmpty(txtUserName.Text) && !String.IsNullOrEmpty(txtPassword.Text))
            {
                SetServiceCredentials(txtUserName.Text, txtPassword.Text);
            }
        }

        private void ClearResultFields()
        {
            var clear = String.Empty;

            txtGeocodedStreet.Text = clear;
            txtGeocodedCity.Text = clear;
            txtGeocodedCounty.Text = clear;
            txtGeocodedState.Text = clear;
            txtGeocodedPostalCode.Text = clear;

            txtCassStreet.Text = clear;
            txtCassCity.Text = clear;
            txtCassState.Text = clear;
            txtCassPostalCode.Text = clear;

            txtJurisdictionCode.Text = clear;
            txtJurisdictionName.Text = clear;            
            txtFIPSCode.Text = clear;
            txtFeatureID.Text = clear;
            chkGeocodedSTD.Checked = false;
            chkUnincorporated.Checked = false;
        }

        private void CredentialsTextChanged(object sender, EventArgs e)
        {
            updateServiceCredentials = true;
            EnableCommandButtons();
        }

        private void EnableCommandButtons()
        {
            Boolean enable = !String.IsNullOrEmpty(txtUserName.Text)
                && !String.IsNullOrEmpty(txtPassword.Text);
            btnGetServerTime.Enabled = enable;
            btnVerifyAddress.Enabled = enable;
        }

        private void DisplayGeocodeResult(EZGeoSaaS.AddressLocation addressLocation)
        {
            // Geocoded Address group
            txtScore.Text = String.Format("{0:0.0}", addressLocation.Score);
            String[] address = addressLocation.StandardizedAddress;
            try 
	        {
                txtGeocodedStreet.Text = address[0];                 
	        }
	        catch (Exception)
	        {		
		        //Ignore
	        }
            txtGeocodedCity.Text = addressLocation.CityName;
            txtGeocodedCounty.Text = addressLocation.County;
            txtGeocodedState.Text = addressLocation.StateName;
            txtGeocodedPostalCode.Text = addressLocation.PostalCode;
            if (!String.IsNullOrEmpty(addressLocation.PostalCodeExtension))
            {
                txtGeocodedPostalCode.Text += "-";
                txtGeocodedPostalCode.Text += addressLocation.PostalCodeExtension;
            }

            // Cass Address group
            if (addressLocation.CassAddress != null)
            {
                var cassAddress = addressLocation.CassAddress;
                txtCassStreet.Text = cassAddress.AddressLine;
                txtCassCity.Text = cassAddress.City;
                txtCassState.Text = cassAddress.State;
                txtCassPostalCode.Text = cassAddress.Zip;
                if (!String.IsNullOrEmpty(cassAddress.Zip4))
                {
                    txtCassPostalCode.Text += "-";
                    txtCassPostalCode.Text += cassAddress.Zip4;
                }
            }

            // Tax Jurisdiction Information group
            txtJurisdictionCode.Text = addressLocation.PCode.ToString();
            txtJurisdictionName.Text = addressLocation.TaxJurisdictionName;
            txtFIPSCode.Text = addressLocation.FipsCode.ToString("0000000000");
            txtFeatureID.Text = addressLocation.FeatureID.ToString();
            chkUnincorporated.Checked = !addressLocation.Incorporated 
                && addressLocation.Country
                .Equals("USA",StringComparison.CurrentCultureIgnoreCase);
            chkGeocodedSTD.Checked = !String
                .IsNullOrEmpty(addressLocation.SpecialTaxDistrictName);
        }

        private EZGeoSaaS.InputAddress GetInputAddress()
        {

            var inputAddress = new EZGeoSaaS.InputAddress();
            inputAddress.StreetAddress = this.txtStreet.Text;
            inputAddress.CityStateZip = this.txtCityStateZip.Text;
            inputAddress.CassCertify = chkCassCertify.Checked;
            inputAddress.MinimumScore = 0.7;
            inputAddress.Offset = 3.0;
            if (chkSpecialTaxDistrict.Checked)
            {
                inputAddress.Options = 24;
            }
            else
            {
                inputAddress.Options = 8;
            }

            return inputAddress;
        }

        private void SetServiceCredentials(String userName, String password)
        {
            //ezgeoServiceClient = new EZGeoSaaS.LocatorServiceClient("WSHttpBinding_IEZGeoSaaSService");
            ezgeoServiceClient = new EZGeoSaaS.LocatorServiceClient("BasicHttpBinding_IEZGeoSaaSService");

            ezgeoServiceClient.ClientCredentials.UserName.UserName = userName;
            ezgeoServiceClient.ClientCredentials.UserName.Password = password;
            updateServiceCredentials = false;
        }

        private void SelectAllText(object sender, EventArgs e)
        {
            ((TextBox)sender).SelectAllText();
        }
    }
}
