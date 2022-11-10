using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnTapExam1.Models
{
    public class Hang
    {
        public String maHang { get; set; }
        public String tenHang { get; set; }
        public String loaiHang { get; set; }
        public int soLuong { get; set; }
        public double donGia { get; set; }
        private double thanhTien;

        public double ThanhTien
        {
            get {
                return thanhTien;
            }

            set {
                if(soLuong >= 100)
                {
                    thanhTien = soLuong * donGia * 0.9;
                } else
                {
                    thanhTien = soLuong * donGia;
                }
            }
        }
    }
}