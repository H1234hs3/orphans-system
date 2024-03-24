using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orphan.Core.Model
{
    public class NewOrphan
    {
        public int Id { get; set; }
        public string? NameOrphan { get; set; }
        public string? OrphanClassification { get; set; }
        public string? Gender { get; set; }
        //public string? Country { get; set; }
        //public string? Directorate { get; set; }
        //public string? Village { get; set; }
        //public string? Nationality { get; set; }
        public string? EducationalLevel { get; set; }
        public string? Classroom { get; set; }
        public int ? PhoneNumber { get; set; }//more than a number
        public string? InsideOrphanage { get; set; }
        public string? HousingType { get; set; }
        public int? NumberRoom { get; set; }
        public double? AmountRent { get; set; }
        public string? PlaceOfBirth { get; set; }
        public int? numberBrothers { get; set; }
        public int? numberSisters { get; set; }
        public string? OrphanStatus { get; set; }
        public string? healthStatus { get; set; }
        public string? CausesDisease { get; set; }
        public string? QualityHousing { get; set; }
        public string? Address { get; set; }
        public DateTime DateBirth { get; set; }
        public string? OrphanHobby { get; set; }
        public string? AmountOfQuran { get; set; }
        public string? ClosestPlaceOtLive { get; set; }
        public string? Description { get; set; }
        public string? IamgeName { get; set; }/// كيف تكون نوع بيانات للصور

        //property of parents
        public string? MotherName { get; set; }
        public string? MotherCondition { get; set; }
        public int? MotherNationalNumber { get; set; }//هل يصح كتابه الاسم كذه كبير
        public string? DMotherWork { get; set; }//

        public string? FatherName { get; set; }
        public int? FatherNationalNumber { get; set; }//
        public string? FatherWorkBeforeDeath { get; set; }//
        public DateTime? DateFatherDeath { get; set; }

        public string? GuardianName { get; set; }
        public string? GuardianWork { get; set; }
        public int? GuardianNationalNumber { get; set; }
        public string? RelationshipWithOrphanhood { get; set; }

        public int StatusId { get; set; }
        public Status Status {get;set;}


        public int CityId { get; set; }
        public City City { get; set; }

        public int CountryId { get; set; }
        public Country country { get; set; }

        public int DirectorateId { get; set; }
        public Directorate Directorate { get; set; }

        public int VillageId { get; set; }
        public Village Village { get; set; }


        public int NationalityId { get; set; }
        public Nationality Nationality { get; set; }

        public List<OrphanAttachment> OrphanAttachment { get; set; }
        public List<GuardianAttachment> GuardianAttachment { get; set; }
        public List<AnnualReport> AnnualReport { get; set; }
        public List<MonthlyMovement> MonthlyMovement { get; set; }
        public List<DataReview> DataReview { get; set; }









    }
}
