import { Component, ElementRef, OnInit, ViewChild } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { MatDialog } from '@angular/material/dialog';
import { Router } from '@angular/router';
import { HomeService } from 'src/app/Service/home.service';
import { AttendanceDialogComponent } from '../attendance-dialog/attendance-dialog.component';
import { MessageDialogComponent } from '../message-dialog/message-dialog.component';
declare var require: any;

import * as pdfMake from "pdfmake/build/pdfmake";
import * as pdfFonts from "pdfmake/build/vfs_fonts";
const htmlToPdfmake = require("html-to-pdfmake");
(pdfMake as any).vfs = pdfFonts.pdfMake.vfs;
import * as XLSX from 'xlsx'; 
import { TDocumentDefinitions } from 'pdfmake/interfaces';
@Component({
  selector: 'app-profile',
  templateUrl: './profile.component.html',
  styleUrls: ['./profile.component.css']
})
export class ProfileComponent implements OnInit {

  Name:string="undefined";
  
  currentYear:Date|any = undefined;

  constructor(private router:Router,private dialog:MatDialog ,public home:HomeService)  {
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
  showProfile()
    {
      //I will get the user from the local storge 
      let user:any=localStorage.getItem('user');
      user=JSON.parse(user);
      
       const id=parseInt(user.email)
       console.log(id)
      if(id)
      {
        this.home.GetSalaryByUserId(id);
        this.home.GetUserByIdAcc(id)
      }
    }
  GoToHome()
  {
    
    this.router.navigate([''])
  }
  InsertMessage()
  {
this.dialog.open(MessageDialogComponent)
  }
  createAttendance()
  {
    this.dialog.open(AttendanceDialogComponent)
  }
  GetTaskJob()
    {
      //I will get the user from the local storge 
      let user:any=localStorage.getItem('user');
      user=JSON.parse(user);
      
       const id=parseInt(user.email)
       console.log(id)
      if(id)
      {
         
        this.home.GetTaskJobById(id)
      }
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
loginIddata:number=2
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
  
  this.home.UpdateProfile(data2);
  
   window.location.reload();

}
@ViewChild('pdfTable')
pdfTable!: ElementRef;

public downloadAsPDF() {
  const pdfTable = this.pdfTable.nativeElement;
  var html = htmlToPdfmake(pdfTable.innerHTML);
  const documentDefinition: TDocumentDefinitions = { 
    content: html,
    pageOrientation: 'landscape',
    pageSize: {
      width:1400, 
      height: 700
    }
   };
  pdfMake.createPdf(documentDefinition).download(); 

}

  fileName= 'ExcelSheet.xlsx';  

exportexcel(): void 
  {
     /* table id is passed over here */   
     let element = document.getElementById('excel-table'); 
     const ws: XLSX.WorkSheet =XLSX.utils.table_to_sheet(element);

     /* generate workbook and add the worksheet */
     const wb: XLSX.WorkBook = XLSX.utils.book_new();
     XLSX.utils.book_append_sheet(wb, ws, 'Sheet1');

     /* save to file */
     XLSX.writeFile(wb, this.fileName);
    
  }

}
