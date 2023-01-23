import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl } from '@angular/forms';
import { MatDialog } from '@angular/material/dialog';
import { Router } from '@angular/router';
import { HomeService } from 'src/app/Service/home.service';
import { CardDialogComponent } from '../card-dialog/card-dialog.component';
import { NewCarDialogComponent } from '../new-car-dialog/new-car-dialog.component';
import { PaymentComponent } from '../payment/payment.component';

@Component({
  selector: 'app-profile',
  templateUrl: './profile.component.html',
  styleUrls: ['./profile.component.css']
})
export class ProfileComponent implements OnInit {

  Name:string="undefined";
  
  currentYear:Date|any = undefined;
  constructor(private router:Router,public homeService : HomeService,private dialog:MatDialog)  {
    this.currentYear = new Date().getFullYear();
    this.Name="MyVehicle Team"
    
    
   }
   formGroup =new FormGroup({
    
    
    fullName: new FormControl(''),
   
    gender: new FormControl(''),   
    age: new FormControl(''),
    email: new FormControl(''),
    address: new FormControl(''),
    phoneNumber: new FormControl(''),
    
    
  }) 
  ngOnInit(): void {
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
  logout()
  {
    localStorage.clear();
    this.router.navigate(['security/login']);
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

  AddPayment()
  {
   this.dialog.open(PaymentComponent)
  }
  user:any=localStorage.getItem('user');
user1=JSON.parse(this.user);
id:number=parseInt(this.user1.email);
roleIddata:number=1;
namedata:any;
image:string="image";
genderdata:any;
agedata:any;
emaildata:any;
addressdata:any;
phonedata:any;
settingIddata:number=1;
loginIddata:number=1
saveItem(){
  debugger
  
  this.id=this.id,
  this.loginIddata=this.loginIddata,
  this.namedata=this.formGroup.value.fullName;
  this.image=this.image;
  this.genderdata=this.formGroup.value.gender;
  this.agedata=this.formGroup.value.age;
  this.emaildata=this.formGroup.value.email;
  this.addressdata=this.formGroup.value.address;
  this.phonedata=this.formGroup.value.phoneNumber;
  this.settingIddata=this.settingIddata;

  const data2={

    
    userId:this.id,
    fullName:this.namedata.toString(),
    userImage:this.image,
    gender:Boolean(this.genderdata),
    age: parseInt(this.agedata),
    email: this.emaildata.toString(),
    address: this.addressdata.toString(),
    phoneNumber:parseInt( this.phonedata),
    settingId:this.settingIddata,
    loginId:this.loginIddata,
    

  }
  console.log(data2)
  this.homeService.UpdateProfile(data2);
  //  window.location.reload();

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
}
