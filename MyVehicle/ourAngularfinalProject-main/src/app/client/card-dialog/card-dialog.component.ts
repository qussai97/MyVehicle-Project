import { Component, OnInit } from '@angular/core';
import { HomeService } from 'src/app/Service/home.service';
import { FormControl, FormGroup, Validators } from '@angular/forms';
@Component({
  selector: 'app-card-dialog',
  templateUrl: './card-dialog.component.html',
  styleUrls: ['./card-dialog.component.css']
})
export class CardDialogComponent implements OnInit {

  formGroup = new FormGroup({
    cardNumber: new FormControl('', [Validators.required]),
    cardName: new FormControl('', [Validators.required]),
    cardDate: new FormControl('', [Validators.required]),
    

  })
  constructor(public home: HomeService) { }

  ngOnInit(): void {
  }
  cardNumberdata: any;
  cardNamedata: any;
  cardDatedata: any;
  
 
   user:any=localStorage.getItem('user');
   user1=JSON.parse(this.user);
          
   userIddata=parseInt(this.user1.email);

  saveItem() {
    debugger
    this.cardNumberdata = this.formGroup.value.cardNumber;
    this.cardNamedata = this.formGroup.value.cardName;
    this.cardDatedata = this.formGroup.value.cardDate;
    
   this.userIddata= this.userIddata;

    const data2 = {
      cardNumber: this.cardNumberdata.toString(),
      cardName: this.cardNamedata.toString(),
      cardDate: this.cardDatedata.toString(),
      
      userId: this.userIddata,
      


    }
    console.log(data2)
    this.home.InsertCard(data2);
    // window.location.reload();

  }
}
