import { Component, Input, OnInit, Output } from '@angular/core';

@Component({
  selector: 'app-aboutus-card',
  templateUrl: './aboutus-card.component.html',
  styleUrls: ['./aboutus-card.component.css']
})
export class AboutusCardComponent implements OnInit {
  @Input () typeLang:string|undefined;
  @Input () subText:string|undefined;
  @Input () description:string|undefined;
 
  constructor() { }

  ngOnInit(): void {
  }

}
