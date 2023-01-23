

import { Component, OnInit } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';

import { Router } from '@angular/router';
import { HomeService } from 'src/app/Service/home.service';
import { UpdateProfileDialogComponent } from '../update-profile-dialog/update-profile-dialog.component';

declare var require: any;

import * as pdfMake from "pdfmake/build/pdfmake";
import * as pdfFonts from "pdfmake/build/vfs_fonts";
const htmlToPdfmake = require("html-to-pdfmake");
(pdfMake as any).vfs = pdfFonts.pdfMake.vfs;

import * as XLSX from 'xlsx'; 
import { TDocumentDefinitions } from 'pdfmake/interfaces';
import { ToastrService } from 'ngx-toastr';
import { NgxSpinnerService } from 'ngx-spinner';
import { TaskJobDialogComponent } from '../task-job-dialog/task-job-dialog.component';
import { LicenseDialogComponent } from '../license-dialog/license-dialog.component';
import { InsuranceDialogComponent } from '../insurance-dialog/insurance-dialog.component';
import { DialogComponent } from '../dialog/dialog.component';
import { FormGroup, FormControl } from '@angular/forms';


@Component({
  selector: 'app-profile',
  templateUrl: './profile.component.html',
  styleUrls: ['./profile.component.css']
})
export class ProfileComponent implements OnInit {

  Name:string="undefined";
  tuser:any;

  currentYear:Date|any = undefined;

  constructor(private router:Router ,public home:HomeService ,  public tostr:ToastrService,

    private spiner:NgxSpinnerService,private dialog:MatDialog)  {
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
       
      this.home.GetUserById(id)
    }
  }

  UpdateAdminProfile()
  {
    this.dialog.open(UpdateProfileDialogComponent)
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
  createEmployee()
  {
this.dialog.open(DialogComponent)
  }

  InsertTaskJob()
  {
this.dialog.open(TaskJobDialogComponent)
  }
  InsertLicensing()
  {
this.dialog.open(LicenseDialogComponent)
  }
  createInsurance()
  {
this.dialog.open(InsuranceDialogComponent)
  }
  GoTosearchvehiclecategory()
{
  this.router.navigate(['admin/search-by-vehicle-category'])
}
GoTosearchlicenseexpiry()
{
  this.router.navigate(['admin/searching-for-vehicles-license-expiry'])
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
  this.home.UpdateProfile(data2);
  //  window.location.reload();

}
}
