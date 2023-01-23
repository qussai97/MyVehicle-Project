import { Component, ElementRef, Input, OnInit, ViewChild } from '@angular/core';
import { Router } from '@angular/router';
import { HomeService } from 'src/app/Service/home.service';

declare var require: any;

import * as pdfMake from "pdfmake/build/pdfmake";
import * as pdfFonts from "pdfmake/build/vfs_fonts";
const htmlToPdfmake = require("html-to-pdfmake");
(pdfMake as any).vfs = pdfFonts.pdfMake.vfs;

import * as XLSX from 'xlsx'; 
import { TDocumentDefinitions } from 'pdfmake/interfaces';
import { ToastrService } from 'ngx-toastr';
import { MatDialog } from '@angular/material/dialog';
import { NgxSpinnerService } from 'ngx-spinner';
import { TaskJobDialogComponent } from '../task-job-dialog/task-job-dialog.component';
import { LicenseDialogComponent } from '../license-dialog/license-dialog.component';
import { InsuranceDialogComponent } from '../insurance-dialog/insurance-dialog.component';
import { DialogComponent } from '../dialog/dialog.component';
import { FormGroup, FormControl } from '@angular/forms';





@Component({
  selector: 'app-report',
  templateUrl: './report.component.html',
  styleUrls: ['./report.component.css']
})
export class ReportComponent implements OnInit {
  @Input() fullName:string='N/A';
  @Input() email:string ='N/A';
  @Input() phoneNumber:number |undefined;
  @Input() age:number |undefined;
  @Input() gender:number |  undefined;
  @Input() vehicleName:string ='N/A';
  @Input() vehicleModel:string ='N/A';
  @Input() vehicleColor:string ='N/A';
  @Input() vehicleCategory:string ='N/A';
  @Input() useType:string |  undefined;
  @Input() registerType:string ='N/A';
  @Input() licenseNumber:string='N/A';
  @Input() licenseExpiry:string ='N/A';
  @Input() paymentDate:string |undefined;
  @Input() paymentAmount:number |  undefined;
  @Input() userImage:string |undefined;
  @Input() roleName:string |undefined;

  formGroup =new FormGroup({
    PaymantDate: new FormControl(''),
    
  })

  Name:string="undefined";

  currentYear:Date|any = undefined;
  constructor(private router:Router ,public home:HomeService ,  public tostr:ToastrService,
    private spiner:NgxSpinnerService,private dialog:MatDialog) {
    this.currentYear = new Date().getFullYear();
    this.Name="MyVehicle Team"


   }

  ngOnInit(): void {
    this.VehicleSystemReport();
  }

  logout()
  {
    localStorage.clear();
    this.router.navigate(['security/login']);
  }

  start:Date|any = undefined;
  GetData(){
    debugger
    this.start=this.formGroup.value.PaymantDate
    const data={PaymantDate:this.start.toString()}
    console.log(data)
    this.home.GetTotalPaymentInDay(data);
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
       
      this.home.GetUserById(id)
    }
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
}


