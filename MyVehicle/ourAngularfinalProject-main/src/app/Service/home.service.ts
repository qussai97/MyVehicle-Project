import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { NgxSpinnerService } from 'ngx-spinner';
import { ToastrService } from 'ngx-toastr';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class HomeService {

//varibles to store data that retrive from api
number_Of_Employees:any =[{}];
number_Of_Users:any =[{}];
total_month_salaries:any=[{}];
total_payment:any=[{}];
users:any =[{}];
vehicle:any =[{}];
data :any =[{}];
financial_report:any =[{}];
Attendance:any =[{}];
fullReport:any =[{}];
payment:any =[{}];
employee_info:any =[{}];
card1 :any =[{}];
paymentCount:any =[{}];
User_profile:any=[{}]
admin_profile:any=[{}];
TaskJoB:any=[{}];
searchlic:any=[{}];
acc_profile:any=[{}]
technecal_report=[{}];
Insurance:any =[{}];
License:any =[{}];
data1 :any =[{}];
About:any =[{}];
bankcard:any=[{}];
countcars:any=[{}];
usercar:any=[{}];
systembetween:any=[{}]
searchlicenseexpiry:any=[{}];
message_user:any=[{}];
reportuser:any=[{}];
driverlicense:any=[{}];
engine_capasty:any=[{}];
contactinfo:any=[{}];
payment_value:any=[{}];
card_date:any=[{}];
acc_Salary:any=[{}];
  constructor(private http:HttpClient,private spiner :NgxSpinnerService,private toastr:ToastrService,private router:Router) {


   }
   //Get Number Of Customer from api
   GetNumberOfCustomer(){
    return this.http.get('https://localhost:44373/api/Users/NumberOfUsers/')
  }
  //Get Number Of Employee from api
  GetNumberOfEmployee(){
    return this.http.get('https://localhost:44373/api/Users/NumberOfEmployees/')
  }

 //Create Employee from api
  CreateEmployee(data:any){
    this.spiner.show();
    debugger
    this.http.post(environment.api +'UserRegistration',data).subscribe((res:any)=>{
      this.toastr.success('Employee Created Successfully');
      this.spiner.hide();
     
    },err=>{
     this.spiner.hide();
     this.toastr.error('Employee Not Created');

    })

  }
//view Vehicle System Report from api
  VehicleSystemReport(){
    return this.http.get('https://localhost:44373/api/Vehicle/VehicleSystemReport')
  }
  // view Financial Reports from api
  ObtainFinancialReports(){
    return this.http.get('https://localhost:44373/api/Users/ObtainFinancialReports')
  }
  //Get List Of Employees from api
  GetListOfEmployees(){
    return this.http.get('https://localhost:44373/api/Users/GetListOfEmployees')
  }



//Add Testimonial from api
  Testimonial(data:any)
   {
     this.spiner.show();
     this.http.post('https://localhost:44373/api/Testimonial',data).subscribe(
     (result:any)=>{
     this.toastr.success('Message Sent Successfully');
     this.spiner.hide();
   },
    err=>{
    this.spiner.hide();
    this.toastr.error(' Message Not Sent');



   })}

//Get Number Of All User from api
  GetNumberOfAllUser()
  {

      return this.http.get('https://localhost:44373/api/Users/GetNumberOfAllUser')
  }
//Get Employees Salaries from api
GetEmployeesSalaries()
{
  return this.http.get('https://localhost:44373/api/Users/EmployeesSalaries')
}

//Get Count Payment from api
GetCountPayment()
{
  return this.http.get('https://localhost:44373/api/Payment/GetCountPayment')
}
//Get All Vehicles from api
GetAllVehicles()
{
  return this.http.get('https://localhost:44373/api/Vehicle/GetAllVehicles')
}

//Get All Salary from api
GetAllSalary()
{
  return this.http.get('https://localhost:44373/api/salary/GetAllSalary')
}

//Search By Vehicle Category from api
SearchByVehicleCategory(category:any)

{
  this.spiner.show();
  debugger
  this.http.post('https://localhost:44373/api/Vehicle/SearchByVehicleCategory',category).subscribe((res:any)=>{
    this.data=res;
    this.toastr.success('Search By Vehicle Category Success');
    this.router.navigate(['admin/search-by-vehicle-category'])
    this.spiner.hide();

  },err=>{
   this.spiner.hide();
   this.toastr.error('Search By Vehicle Category Error');

  }) 
 
}
//Get Total Month Salaries from api
TotalMonthSalaries(month:any)

{
  this.spiner.show();
  debugger
  this.http.post('https://localhost:44373/api/Salary/TotalMonthSalaries',month).subscribe((res:any)=>{
    this.total_month_salaries=res;
    console.log(this.total_month_salaries);
    this.toastr.success('Total Month Salaries Success');
    
    this.spiner.hide();

  },err=>{
   this.spiner.hide();
   this.toastr.error('Total Month Salaries Error');

  })

}
//Get Total Payment In Day from api
GetTotalPaymentInDay(day:any)

{
  this.spiner.show();
  debugger
  this.http.post('https://localhost:44373/api/Payment/GetTotalPaymentInDay',day).subscribe((res:any)=>{
    this.total_payment=res;
    console.log(this.total_payment);
    this.toastr.success('Get Total Payment In Day Success');
   
    this.spiner.hide();

  },err=>{
   this.spiner.hide();
   this.toastr.error('Get Total Payment In Day Error');

  })

}

//Searching For Vehicles LicenseExpiry
SearchingForVehiclesLicenseExpiry(dateFromTo:any)

{
  this.spiner.show();
  debugger
  this.http.post('https://localhost:44373/api/Vehicle/SearchingForVehiclesLicenseExpiry',dateFromTo).subscribe((res:any)=>{
    this.searchlic=res;

    this.toastr.success('SearchingForVehiclesLicenseExpiry Success');
    this.router.navigate(['admin/searching-for-vehicles-license-expiry'])
    this.spiner.hide();

  },err=>{
   this.spiner.hide();
   this.toastr.error('SearchingForVehiclesLicenseExpiry Error');

  })

}

//Create attendance from api
Createattendance(data:any){
  this.spiner.show();
  debugger
  this.http.post('https://localhost:44373/api/Attendance',data).subscribe((res:any)=>{
    this.toastr.success('Create attendance Created');
    this.spiner.hide();

  },err=>{
   this.spiner.hide();
   this.toastr.error('Createa ttendance Not Created');

  })

}

//Get All Attendance from api
GetAllAttendance(){
  return this.http.get('https://localhost:44373/api/Attendance/GetAllAttendance')
}

//Get All Payments from api
GetAllPayments(){
  return this.http.get('https://localhost:44373/api/Payment/GetAllPayments')
}
//Get All License from api
GetAllLicense(){
  return this.http.get('https://localhost:44373/api/Licensing/GetAllLicensing')
}
//Get All Insurance from api
GetAllInsurance(){
  return this.http.get('https://localhost:44373/api/Insurance/GetAllInsurance')
}
//Get All About
GetAllAbout()
{
  return this.http.get('https://localhost:44373/api/About/GetAllAbout')
}

//Insert New Car Licensing
InsertNewCarLicensing(data:any){
  this.spiner.show();
  debugger
  this.http.post('https://localhost:44373/api/NewCarLicensing',data).subscribe((res:any)=>{
    this.payment_value=res;
    this.toastr.success('New Car Licensing Created');
    console.log(this.payment_value);
    this.spiner.hide();

  },err=>{
   this.spiner.hide();
   this.toastr.error('New Car Licensing Not Created');

  })
}


//Create Insurance 
CreateInsurance(data:any){
  this.spiner.show();
  debugger
  this.http.post('https://localhost:44373/api/Insurance',data).subscribe((res:any)=>{
    this.toastr.success(' Insurance Created');
    this.spiner.hide();


  },err=>{
   this.spiner.hide();
   this.toastr.error('Insurance Not Created');

  })

}
//Get User By Id from api
GetUserById(id:number)
    {
      this.spiner.show();

      this.http.get('https://localhost:44373/api/Users/GetAllUsersById/'+id).subscribe((res:any)=>{

        this.admin_profile=res;
        this.spiner.hide();
        this.router.navigate(['admin/profile']);
        this.toastr.success("Data return success")
      },err=>{
        this.spiner.hide();
        this.toastr.error("Data not return")
      })
    }

    //Get User ByIdAcc from api
    GetUserByIdAcc(id:number)
    {
      this.spiner.show();

      this.http.get('https://localhost:44373/api/Users/GetAllUsersById/'+id).subscribe((res:any)=>{

        this.acc_profile=res;
        this.spiner.hide();
        console.log(this.acc_profile);
        this.router.navigate(['accountant/profile']);
        this.toastr.success("Data return success")
      },err=>{
        this.spiner.hide();
        this.toastr.error("Data not return")
      })
    }
    //Get User ByIdUser from api
    GetUserByIdUser(id:number)
    {
      this.spiner.show();
      
      this.http.get('https://localhost:44373/api/Users/GetAllUsersById/'+id).subscribe((res:any)=>{
        
        this.User_profile=res;
        this.spiner.hide();
        this.router.navigate(['client/profile']);
        this.toastr.success("Data return success")
      },err=>{
        this.spiner.hide();
        this.toastr.error("Data not return")
      })
    }
    //Delete User by ID
    DeleteUserbyID(id:number){
      this.spiner.show();
      debugger
      this.http.delete('https://localhost:44373/api/Users/delete/'+id)
      .subscribe((date:any)=>{
        this.spiner.hide();
        this.toastr.success(' The User Deleted ');

      },err=>{
        this.spiner.hide();
        this.toastr.error('Not Deleted');

      })


        }


//Insert TaskJob
InsertTaskJob(data:any){
  this.spiner.show();
  debugger
  this.http.post('https://localhost:44373/api/TaskJob/InsertTaskJob',data).subscribe((res:any)=>{
    this.toastr.success('TaskJob Created');
    console.log(this.data);
    this.spiner.hide();

  },err=>{
   this.spiner.hide();
   this.toastr.error('TaskJob Not Created');

  });
}

//Insert Licensing from api
  InsertLicensing(data:any){
    this.spiner.show();
    debugger
    this.http.post('https://localhost:44373/api/Licensing',data).subscribe((res:any)=>{
      this.toastr.success('Licensing Created');
      console.log(this.data);
      this.spiner.hide();

    },err=>{
     this.spiner.hide();
     this.toastr.error('Licensing Not Created');

    })
  }
  //Insert Message 
  InsertMessage(data:any){
    this.spiner.show();
    debugger
    this.http.post('https://localhost:44373/api/Message/InsertMessage',data).subscribe((res:any)=>{
      this.toastr.success('Message Created');
      console.log(this.data);
      this.spiner.hide();

    },err=>{
     this.spiner.hide();
     this.toastr.error('Message Not Created');

    })

  }
//Update Profile
  UpdateProfile(data:any){
    this.spiner.show();
    debugger
    this.http.put('https://localhost:44373/api/Users',data).subscribe((res:any)=>{
      this.toastr.success('Data Update Success');
      console.log(this.data);
      this.spiner.hide();

    },err=>{
     this.spiner.hide();
     this.toastr.error('Data Not Updated');

    });
  }

//Get Task Job By Id from api
GetTaskJobById(id:number)
{
  this.spiner.show();

  this.http.get('https://localhost:44373/api/TaskJob/TaskJobById/'+id).subscribe((res:any)=>{

    this.TaskJoB=res;
    this.spiner.hide();
    this.router.navigate(['accountant/get-task-job']);
    this.toastr.success("Data return success")
  },err=>{
    this.spiner.hide();
    this.toastr.error("Data not return")
  })
}
//Vehicle System Report Between start date and end date
VehicleSystemReportBetween(dateFromTo:any)

{
  this.spiner.show();
  debugger
  this.http.post('https://localhost:44373/api/Vehicle/VehicleSystemReportBetween',dateFromTo).subscribe((res:any)=>{
    this.systembetween=res;
    this.toastr.success('VehicleSystemRepor Success');
    this.router.navigate(['admin/vehicle-system-report-between'])
    this.spiner.hide();

  },err=>{
   this.spiner.hide();
   this.toastr.error('Search Error');

  })

}

//Vehicle System Report for accountant
VehicleSystemReportBetweenAcc(dateFromTo:any)

{
  this.spiner.show();
  debugger
  this.http.post('https://localhost:44373/api/Vehicle/VehicleSystemReportBetween',dateFromTo).subscribe((res:any)=>{
    this.searchlic=res;
    this.toastr.success('VehicleSystemRepor Success');
    this.router.navigate(['accountant/vehicle-system-report-between'])
    this.spiner.hide();

  },err=>{
   this.spiner.hide();
   this.toastr.error('Search Error');

  })

}
//Get Message By UsrId
  GetMessageByUsrId(id:number)
    {
      this.spiner.show();

      this.http.get('https://localhost:44373/api/Message/GetMessageByUserId/'+id).subscribe((res:any)=>{

        this.message_user=res;
        this.spiner.hide();
        this.router.navigate(['client/get-message']);

        this.toastr.success("get-message return success")

      },err=>{
        this.spiner.hide();
        this.toastr.error("get-message not return")
      })
    }
//Technecal Report
    TechnecalReport(id:number)
    {
      this.spiner.show();

      this.http.get('https://localhost:44373/api/Vehicle/TechnecalReport/'+id).subscribe((res:any)=>{

        this.reportuser=res;
        this.spiner.hide();
        this.router.navigate(['client/get-technecal-report']);

        this.toastr.success("get-technecal-report return success")

      },err=>{
        this.spiner.hide();
        this.toastr.error("get-technecal-report not return")
      })
    }
//get Driving License
    GetDrivingLicense(id:number)
    {
      this.spiner.show();

      this.http.get('https://localhost:44373/api/Users/GetDrivingLicense/'+id).subscribe((res:any)=>{

        this.driverlicense=res;
        this.spiner.hide();
        this.router.navigate(['client/get-driving-license']);

        this.toastr.success("get-driving-license return success")

      },err=>{
        this.spiner.hide();
        this.toastr.error("get-driving-license not return")
      })
    }
    //get total Licensing cost 
    TotalCost(EngineCapasty:any)

    {
      this.spiner.show();
      debugger
      this.http.post('https://localhost:44373/api/Licensing/SearchLicensingCost',EngineCapasty).subscribe((res:any)=>{
        this.engine_capasty=res;
        console.log(this.engine_capasty);
        this.toastr.success(' Search for Licensing Cost Success');
        this.router.navigate(['client/client'])
        this.spiner.hide();

      },err=>{
       this.spiner.hide();
       this.toastr.error('Search Error');

      })

    }
    //Get bankcard by userid 
    GetBankcard(id:number)
    {
      this.spiner.show();

      this.http.get('https://localhost:44373/api/Cards/GetCardById/'+id).subscribe((res:any)=>{

        this.bankcard=res;
        this.spiner.hide();
        this.router.navigate(['client/view-bankcard']);
        console.log(this.bankcard)
        this.toastr.success("view-bankcard return success")

      },err=>{
        this.spiner.hide();
        this.toastr.error("view-bankcard not return")
      })
    }
//add payment
    InsertPayment(data:any){
      this.spiner.show();
      debugger
      this.http.post('https://localhost:44373/api/Payment',data).subscribe((res:any)=>{
        this.toastr.success('Payment Completed Successfully');
        console.log(this.data);
        this.spiner.hide();

      },err=>{
       this.spiner.hide();
       this.toastr.error(' Not Created');

      })

    }
//count user cars
    CountUserCars(id:number)
    {
      this.spiner.show();
      
      this.http.get('https://localhost:44373/api/Users/CountUserCars/'+id).subscribe((res:any)=>{
        
        this.countcars=res;
        this.spiner.hide();
        this.router.navigate(['client/client']);
        console.log(this.bankcard)
       
        
      },err=>{
        this.spiner.hide();
        
      })
    }
//Search for car By UserId
    SearchByUserId(id:number)
    {
      this.spiner.show();
      
      this.http.get('https://localhost:44373/api/Users/SearchByUserId/'+id).subscribe((res:any)=>{
        
        this.usercar=res;
        this.spiner.hide();
        this.router.navigate(['client/client']);
        console.log(this.bankcard)
        this.toastr.success("SearchByUserId success")
        
      },err=>{
        this.spiner.hide();
        this.toastr.error("SearchByUserId not return")
      })
    }

    // View User Contact Information
    ViewUserContactInformation(dateFromTo:any)

    {
      this.spiner.show();
      debugger
      this.http.post('https://localhost:44373/api/Users/ViewUserContactInformation',dateFromTo).subscribe((res:any)=>{
        this.contactinfo=res;
    
        this.toastr.success('UserContactInformation Success');
        this.router.navigate(['accountant/user-contact-info'])
        this.spiner.hide();
    
      },err=>{
       this.spiner.hide();
       this.toastr.error('Search Error');
    
      })
    
    }
//add new card
InsertCard(data:any){
  this.spiner.show();
  debugger
  this.http.post('https://localhost:44373/api/Cards',data).subscribe((res:any)=>{
    this.card_date=res;
    this.toastr.success(' Card Created Success');
    console.log(this.card_date);
    this.spiner.hide();

  },err=>{
   this.spiner.hide();
   this.toastr.error(' Not Created');

  })
}




//Get Salary Statement
GetSalaryByUserId(id:number)
    {
      this.spiner.show();

      this.http.get('https://localhost:44373/api/Salary/GetSalaryById/'+id).subscribe((res:any)=>{

        this.acc_Salary=res;
        console.log(this.acc_Salary);
        this.spiner.hide();
        
        this.router.navigate(['accountant/profile']);
        this.toastr.success("Salary return success")
      },err=>{
        this.spiner.hide();
        this.toastr.error("Data not return")
      })
    }

    //Send Email To User
    
    SendEmail(ToEmail:any)

    {
      this.spiner.show();
      debugger
      this.http.post('https://localhost:44373/api/Email/Send',ToEmail).subscribe((res:any)=>{
       
    
        this.toastr.success('Email Sent Success,Check Your Email');
        
        this.spiner.hide();
    
      },err=>{
       this.spiner.hide();
       this.toastr.error('Email Not Sent');
    
      })
    
    }

  }