using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constans
{
    public static class Messages
    {
        public static string CarAdded = "Car Added.";
        public static string CarNameInvalid = "Car name is invalid.";
        public static string DailyPriceInvalid = "DailyPrice of Car must be maximum 0.";
        public static string MaintenanceTime="System maintenance";
        public static string CarUpdated="Car Updated";
        public static string RentalInvalid="Rental Invalid!!";
        public static string Rent_A_Car="Rent A Car";
        public static string AddedCarImage="Araba resmi eklendi.";
        public static string SuccedCarImageAdd="Araç resmi ekleme başarılı.";
        public static string DeletedCarImage="Araba resmi silindi.";
        public static string UpdatedCarImage="Araba resmi güncellendi.";
        public static string CarImageNotNull="Araba resmi var.";
        public static string AuthorizationDenied="Yetkiniz yok";
        public static string UserNotFound="Kullanıcı bulunamadı.";
        public static string PasswordError="Şifre hatalı!";
        public static string SuccessfulLogin="Giriş başarılı...";
        public static string UserAlreadyExists="Kullanıcı mevcut";
        public static string AccessTokenCreated="Token oluşturuldu.";
        public static string UserRegistered="Kullanıcı kayıt oldu.";
    }
}
