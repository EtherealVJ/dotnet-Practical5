using System;
using System.Collections.Generic;
using System.Text;
using RentedVehicle;

class Program {
    static void Main(string[] args) {

        Indica i = new Indica("PETROL",4,"GJ 01 VJ 1031", VehicleInterface.Renttype.PERDAY,9,5, new DateOnly(2022,01,02));

        Qualis q = new Qualis("DIESEL",8,"GJ 06 VJ 1009", VehicleInterface.Renttype.PERKILOMETER,5,7, new DateOnly(2021,12,15));

        DavidHarley dh1 = new DavidHarley("PETROL",2,"MH 01 VJ 1010",VehicleInterface.Renttype.PERDAY,2,10,new DateOnly(2022,02,14));

        DavidHarley dh2 = new DavidHarley("DIESEL",4,"MH 01 VJ 1010",VehicleInterface.Renttype.PERKILOMETER,2,8,new DateOnly(2022,02,01));       

        MBenzE mb = new MBenzE("PETROL",4, "MH 01 VJ 2510", VehicleInterface.Renttype.PERKILOMETER,4,15, new DateOnly(2022,01,14));

        RentedVehicle<VehicleInterface> RentedVehicleVJ = new RentedVehicle<VehicleInterface>();

        RentedVehicleVJ.AddVehicle(i);
        RentedVehicleVJ.AddVehicle(q);
        RentedVehicleVJ.AddVehicle(dh1);
        RentedVehicleVJ.AddVehicle(dh2);
        RentedVehicleVJ.AddVehicle(mb);
       

        RentedVehicleVJ.GiveForRent(i, new DateOnly(2022,01,10), new DateOnly(2022,01,31),250);
        RentedVehicleVJ.GiveForRent(mb, new DateOnly(2022,03,09), new DateOnly(2022,03,31),500);
        RentedVehicleVJ.GiveForRent(dh1, new DateOnly(2022,04,15), new DateOnly(2022,04,25),400);

        Console.Write("\nCAR DATA [MERCEDES BENZ] : ");
        mb.getData();

        Console.Write("\n^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");

        Console.Write($"\n\nTOTAL RENT PER DAY [DAVID HARLEY - 1] : {RentedVehicleVJ.CalculateTotalRentToday(dh1, 77):C2}");

        Console.Write("\n\n^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");

        Console.Write("\n\nNO. OF VEHICLES RENTED :");

        RentedVehicleVJ.GetCheckListRentedAndAvailableVehicle();

        Console.Write("\n^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");

        Console.Write("\n\nAVAILABILITY OF VEHICLES BEFORE 26 FEB 2022 :");

        RentedVehicleVJ.ShowAvailabilityForBookingForGivendateByDate(new DateOnly(2022,02,26));       
    }
}