using System.ComponentModel.DataAnnotations.Schema;

namespace quiz_api.Models
{
    public class Question
    {
        public int QuestionId { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        public string QuestionInWords { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string ImageName { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Option01 { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Option02 { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Option03 { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Option04 { get; set; }
        public int Answer { get; set; }
    }
}
