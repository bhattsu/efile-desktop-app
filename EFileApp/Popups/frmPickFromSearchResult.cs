using EFileApp.DTOs;
using MaterialSkin.Controls;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EFileApp.Popups
{
    public partial class frmPickFromSearchResult : MaterialForm
    {
        private readonly List<CaseSearchResultDTO> _results;
        private readonly frmCodeGenarator _frmCodeGenarator;

        public frmPickFromSearchResult(List<CaseSearchResultDTO> results, frmCodeGenarator frmCodeGenarator)
        {
            InitializeComponent();
            _results = results;
            _frmCodeGenarator = frmCodeGenarator;



            //Add
            foreach (var result in results)
            {

                var item = new ListViewItem(new[] {
                    result.CaseNumber,
                    result.CaseTitle,
                    result.CaseCategory,
                    result.Jurisdiction});

                materialListView1.Items.Add(item);
            }
        }

        private async  void btnSelect_Click(object sender, System.EventArgs e)
        {
            frmPleaseWait wait = new frmPleaseWait();
            wait.Show(); 
            Application.DoEvents();
            await _frmCodeGenarator.GetCaseDetailsByIdAsync(_results[materialListView1.SelectedItems[0].Index]);
            wait.Close(); 
            this.Close();
            
        }
    }
}
