import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { HomeService } from 'src/app/Service/home.service';

@Component({
  selector: 'app-message-dialog',
  templateUrl: './message-dialog.component.html',
  styleUrls: ['./message-dialog.component.css']
})
export class MessageDialogComponent implements OnInit {
  // MesParameter.Add("@MessageText", Mes.MessageText, dbType: DbType.String, direction: ParameterDirection.Input);
  // MesParameter.Add("@MessageStatus", Mes.MessageStatus, dbType: DbType.Boolean, direction: ParameterDirection.Input);
  // MesParameter.Add("@SenderName", Mes.SenderName, dbType: DbType.String, direction: ParameterDirection.Input);
  // MesParameter.Add("@MessageTitle", Mes.MessageTitle, dbType: DbType.String, direction: ParameterDirection.Input);
  // MesParameter.Add("@MessageDate", Mes.MessageDate, dbType: DbType.DateTime, direction: ParameterDirection.Input);
  // MesParameter.Add("@UserId", Mes.UserId, dbType: DbType.Int32, direction: ParameterDirection.Input);
  formGroup =new FormGroup({
    messageText: new FormControl('', [Validators.required]),
    // messageStatus:new FormControl('',[Validators.required]),
    senderName: new FormControl('', [Validators.required]),
    messageTitle: new FormControl('', [Validators.required]),
    messageDate:new FormControl('',[Validators.required]),
    
    userId:new FormControl('',[Validators.required]),
   
    
  }) 
  
  constructor(public home:HomeService) { }

  ngOnInit(): void {
  }
  messageTextdata:any;
  messageStatusdata:number=1;
     senderNamedata:any;
   messageTitledata:any;
    messageDatedata:any;
 userIddata:any;
 
  saveItem(){
    debugger
    this.messageTextdata=this.formGroup.value.messageText;
    this.messageStatusdata=this.messageStatusdata;
    this.senderNamedata=this.formGroup.value.senderName;
    this.messageTitledata=this.formGroup.value.messageTitle;
    this.messageDatedata=this.formGroup.value.messageDate;
    this.userIddata=this.formGroup.value.userId;
 
 
    const data2={

      messageText:this.messageTextdata,
      messageStatus:Boolean(this.messageStatusdata),
      senderName:this.senderNamedata,
      messageTitle:this.messageTitledata,
      messageDate:this.messageDatedata,
      userId:parseInt( this.userIddata)
      

    }
    console.log(data2)
    this.home.InsertMessage(data2);
    // window.location.reload();

  }

}
