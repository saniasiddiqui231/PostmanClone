using System;
using System.Linq.Expressions;
using System.Text;
using PostmanCloneLibrary;

namespace PostmanCloneUI
{
    public partial class Form1 : Form
    {
        private readonly IapiAccess api = new apiAccess();
        public Form1()
        {
            InitializeComponent();
            httpVerbSelection.SelectedItem = "GET";

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void apiLabel_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void statusStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private async void buttonLabel_Click(object sender, EventArgs e)
        {

            resultTextLabel.Text = "";
            if (api.IsValidUrl(apiText.Text) == false)
            {
                return;
            }

            string selectedMethod = httpVerbSelection.SelectedItem?.ToString() ?? "GET";
            HttpAction action = Enum.TryParse(selectedMethod, out HttpAction parsedAction) ? parsedAction : HttpAction.GET;

            HttpContent? content = null;

            if (action == HttpAction.POST || action == HttpAction.PUT || action == HttpAction.PATCH)
            {
               
                content = new StringContent(resultTextLabel.Text, Encoding.UTF8, "application/json");
            }

            try
            {
                resultTextLabel.Text = await api.CallApiAsync(apiText.Text, action, content);
                callData.SelectedTab = outputTab;
            }
            catch (Exception ex)
            {
                resultTextLabel.Text = "Error: " + ex.Message;
            }

        }

        private void HeaderLabel_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
