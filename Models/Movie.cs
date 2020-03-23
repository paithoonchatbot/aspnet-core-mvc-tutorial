using System;
using System.ComponentModel.DataAnnotations;

namespace demo_mvc.Models
{
  public class Movie
  {
    [Display(Name = "รหัสภาพยนตร์")]
    public int Id { get; set; }
    [Display(Name = "ชื่อเรื่อง")]
    public string Title { get; set; }
    [Display(Name = "วันที่ออกอากาศ")]
    // [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "วันที่ {0:d MMMM yyyy}")]
    public DateTime ReleaseDate { get; set; }
    [Display(Name = "ประเภท")]
    public string Genre { get; set; }
    [Display(Name = "ราคา")]
    [DisplayFormat(DataFormatString = "{0:N4}")]
    public decimal Price { get; set; }
  }
}