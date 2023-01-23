import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { MatDialog } from '@angular/material/dialog';
import { Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { HomeService } from 'src/app/Service/home.service';
import { CardDialogComponent } from '../card-dialog/card-dialog.component';
import { NewCarDialogComponent } from '../new-car-dialog/new-car-dialog.component';
import { PaymentComponent } from '../payment/payment.component';

@Component({
  selector: 'app-client',
  templateUrl: './client.component.html',
  styleUrls: ['./client.component.css']
})
export class ClientComponent implements OnInit {

  formGroup =new FormGroup({
    engineCapasty: new FormControl(''),
    
  })
  Name:string="undefined";
  
  currentYear:Date|any = undefined;
  constructor(private router:Router,public homeService : HomeService,private dialog:MatDialog, public tostr:ToastrService)  {
    this.currentYear = new Date().getFullYear();
    this.Name="MyVehicle Team"
    
    
   }
  ngOnInit(): void {

    this.CountUserCar();
    this.SearchByUser();
    this.GetAllLicense();
    this.GetAllInsurance();
  }
  logout()
  {
    localStorage.clear();
    this.router.navigate(['security/login']);
  }
 
  showProfile()
  {
    //I will get the user from the local storge 
    let user:any=localStorage.getItem('user');
    user=JSON.parse(user);
    
     const id=parseInt(user.email)
     console.log(id)
    if(id)
    {
       
      this.homeService.GetUserByIdUser(id)
    }
  }
  GoToAbout()
  {
    this.router.navigate(['about'])
  }

  GoToContact()
  {
    this.router.navigate(['contactus'])
  }
  
  GoToHome()
  {
    
    this.router.navigate([''])
  }
  showMessage()
  {
    //I will get the user from the local storge 
    let user:any=localStorage.getItem('user');
    user=JSON.parse(user);
    
     const id=parseInt(user.email)
     console.log(id)
    if(id)
    {
       
      this.homeService.GetMessageByUsrId(id)
    }
  }

  TechnecalReportUser()
  {
    //I will get the user from the local storge 
    let user:any=localStorage.getItem('user');
    user=JSON.parse(user);
    
     const id=parseInt(user.email)
     console.log(id)
    if(id)
    {
       
      this.homeService.TechnecalReport(id)
    }

  }

  DrivingLicense()
  {
    //I will get the user from the local storge 
    let user:any=localStorage.getItem('user');
    user=JSON.parse(user);
    
     const id=parseInt(user.email)
     console.log(id)
    if(id)
    {
       
      this.homeService.GetDrivingLicense(id)
    }
  }

  engin:number |undefined;
  GetData(){
    this.engin=this.formGroup.value.engineCapasty
    const data={engineCapasty:this.engin}
    console.log(data)
    
    this.homeService.TotalCost(data);
    
  }

  GetBankcardByUserId()
  {
    //I will get the user from the local storge 
    let user:any=localStorage.getItem('user');
    user=JSON.parse(user);
    
     const id=parseInt(user.email)
     console.log(id)
    if(id)
    {
       
      this.homeService.GetBankcard(id)
    }
  }
  AddPayment()
  {
   this.dialog.open(PaymentComponent)
  }
 
  InsertCar()
  {
   this.dialog.open(NewCarDialogComponent)
  }
  AddCard()
  {
   this.dialog.open(CardDialogComponent)
  }
  GoToViewCard()
  {
    
    this.router.navigate(['client/view-bankcard'])
  }

  CountUserCar()
  {
    //I will get the user from the local storge 
    let user:any=localStorage.getItem('user');
    user=JSON.parse(user);
    
     const id=parseInt(user.email)
     console.log(id)
    if(id)
    {
       
      this.homeService.CountUserCars(id)
    }
  }

  SearchByUser()
  {
    //I will get the user from the local storge 
    let user:any=localStorage.getItem('user');
    user=JSON.parse(user);
    
     const id=parseInt(user.email)
     console.log(id)
    if(id)
    {
       
      this.homeService.SearchByUserId(id)
    }
  }
  GetAllLicense(){ this.homeService.GetAllLicense().subscribe((res:any)=>{
    this.homeService.License=res;
    
   console.log(this.homeService.License)

  },err=>{

    console.log("err")
  });



  }
  GetAllInsurance(){ this.homeService.GetAllInsurance().subscribe((reas:any)=>{
    this.homeService.Insurance=reas;
   
   console.log("homeService.Insurance")

  },err=>{

    console.log("err")
  });
}
}
