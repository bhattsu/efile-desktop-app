using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFileApp.DTOs
{
    public class EditCasePartyDTO
    {
        public int RowIndex { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }

        public string PartyType { get; set; }
        public bool IsFiling { get; set; }
        public string GUID { get; set; }

        public string Code { get; set; }
        public bool IsRequired { get; set; }
        public string Address { get; set; }
        public string LeadAttorney { get; set; }
        public string LeadAttorneyId { get; set; }

        public bool Checked { get; set; }
        public List<string> AssociatedAttorneysId { get; set; }
        public string AssociatedAttorneys { get; set; }

    }
}
