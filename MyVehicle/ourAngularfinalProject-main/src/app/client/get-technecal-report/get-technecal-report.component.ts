import { Component, OnInit,Input, ViewChild, ElementRef } from '@angular/core';
import { Router } from '@angular/router';
import { HomeService } from 'src/app/Service/home.service';
declare var require: any;

import * as pdfMake from "pdfmake/build/pdfmake";
import * as pdfFonts from "pdfmake/build/vfs_fonts";
const htmlToPdfmake = require("html-to-pdfmake");
(pdfMake as any).vfs = pdfFonts.pdfMake.vfs;
import * as XLSX from 'xlsx';

import { TDocumentDefinitions } from 'pdfmake/interfaces';
import { PaymentComponent } from '../payment/payment.component';
import { MatDialog } from '@angular/material/dialog';
import { CardDialogComponent } from '../card-dialog/card-dialog.component';
import { NewCarDialogComponent } from '../new-car-dialog/new-car-dialog.component';

@Component({
  selector: 'app-get-technecal-report',
  templateUrl: './get-technecal-report.component.html',
  styleUrls: ['./get-technecal-report.component.css']
})
export class GetTechnecalReportComponent implements OnInit {

 
 
 
  
  Name:string="undefined";
  
  currentYear:Date|any = undefined;
  constructor(private router:Router,public homeService : HomeService,private dialog:MatDialog)  {
    this.currentYear = new Date().getFullYear();
    this.Name="MyVehicle Team"
    
    
   }
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
       
      this.homeService.GetUserByIdUser(id)
    }
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
      window.location.reload();
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
  @ViewChild('pdfTable')
      pdfTable!: ElementRef;

      public downloadAsPDF() {
        const pdfTable = this.pdfTable.nativeElement;
        var html = htmlToPdfmake(pdfTable.innerHTML);
        const documentDefinition = { content: html };
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
        

}
