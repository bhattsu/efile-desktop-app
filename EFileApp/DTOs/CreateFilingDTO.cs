using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFileApp.DTOs
{
    public class CreateFilingDTO
    {
        public string LocationCode { get; set; }
        public string CaseCategoryCode { get; set; }
        public string CaseTypeCode { get; set; }


        public string FilingName { get; set; }
        public string FilingCode { get; set; }
        public string SecurityName { get; set; }
        public string SecurtCode { get; set; }

        public string LeadDocumentCode { get; set; }
        public string LeadDocumentPath { get; set; }
        public List<FilingAttachmentDTO> Attachments { get; set; }

        public List<EditCasePartyDTO> CaseParties { get; set; }
        public List<OptionalServiceDTO> OptionalServices { get; set; }
    }


    public class FilingAttachmentDTO
    {
        public string Path { get; set; }
        public string Security { get; set; }
    }
}
