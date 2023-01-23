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
import { FormControl, FormGroup } from '@angular/forms';

@Component({
  selector: 'app-search-by-vehicle-category',
  templateUrl: './search-by-vehicle-category.component.html',
  styleUrls: ['./search-by-vehicle-category.component.css']
})
export class SearchByVehicleCategoryComponent implements OnInit {
  
  formGroupCategory =new FormGroup({
    VehicleCategory: new FormControl(''),
    
  })
  Name:string="undefined";
  currentYear:Date|any = undefined;
  constructor(private router:Router ,public home:HomeService ,  public tostr:ToastrService,
    private spiner:NgxSpinnerService,private dialog:MatDialog) {
    this.currentYear = new Date().getFullYear();
    this.Name="MyVehicle Team"
  
  }
  ngOnInit(): void {
  }
  Category:any;
  GetData(){
    this.Category=this.formGroupCategory.value.VehicleCategory
    const data={VehicleCategory:this.Category.toString()}
    console.log(data)
    this.home.SearchByVehicleCategory(data);
  }

  logout()
  {
    localStorage.clear();
    this.router.navigate(['security/login']);
  }  showProfile()
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



