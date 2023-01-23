import { Component, ElementRef, Input, OnInit, ViewChild } from '@angular/core';
import { Router } from '@angular/router';
import { HomeService } from 'src/app/Service/home.service';

declare var require: any;

import * as pdfMake from "pdfmake/build/pdfmake";
import * as pdfFonts from "pdfmake/build/vfs_fonts";
const htmlToPdfmake = require("html-to-pdfmake");
(pdfMake as any).vfs = pdfFonts.pdfMake.vfs;

import * as XLSX from 'xlsx'; 

import { ToastrService } from 'ngx-toastr';
import { MatDialog } from '@angular/material/dialog';
import { NgxSpinnerService } from 'ngx-spinner';
import { FormControl, FormGroup } from '@angular/forms';
import { TDocumentDefinitions } from 'pdfmake/interfaces';
import { AttendanceDialogComponent } from '../attendance-dialog/attendance-dialog.component';
import { MessageDialogComponent } from '../message-dialog/message-dialog.component';

@Component({
  selector: 'app-vehicle-system-report-between',
  templateUrl: './vehicle-system-report-between.component.html',
  styleUrls: ['./vehicle-system-report-between.component.css']
})
export class VehicleSystemReportBetweenComponent implements OnInit {
  formGroup =new FormGroup({
    startPaymentDate: new FormControl(''),
    endPaymentDate: new FormControl(''),
  })

  
  Name:string="undefined";
  currentYear:Date|any = undefined;
  constructor(private router:Router ,public home:HomeService ,  public tostr:ToastrService,
    private spiner:NgxSpinnerService,private dialog:MatDialog)  {
    this.currentYear = new Date().getFullYear();
    this.Name="MyVehicle Team"
    }
  ngOnInit(): void {
  }

  from:any;
  to:any;
    GetData(){
      this.from=this.formGroup.value.startPaymentDate;
      this.to=this.formGroup.value.endPaymentDate;
      const searchlic={startPaymentDate:this.from.toString(),endPaymentDate:this.to.toString()}
      console.log(searchlic)
      this.home.VehicleSystemReportBetweenAcc(searchlic);
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
  
    VehicleSystemReport(){
  
  this.home.VehicleSystemReport().subscribe((res:any)=>{
  
    this.home.fullReport=res;
   console.log(this.home.fullReport)
   
  
  },err=>{
    console.log("err")
  });
  
    }
  
    @ViewChild('pdfTable')
    pdfTable!: ElementRef;
  
    public downloadAsPDF() {
      const pdfTable = this.pdfTable.nativeElement;
      var html = htmlToPdfmake(pdfTable.innerHTML);
  console.log("clicked")
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
  }
  
  
  