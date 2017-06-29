import { Component, OnInit, Input } from '@angular/core';
import { ICvUser } from './../../interfaces/i-user';

@Component({
  selector: 'app-view-cv-user-header',
  templateUrl: './view-cv-user-header.component.html',
  styleUrls: ['./view-cv-user-header.component.css']
})
export class ViewCvUserHeaderComponent implements OnInit {
  @Input() userInfo: any;
  constructor() {
    this.userInfo = this.userInfo as ICvUser;

  }

  ngOnInit() {
  }

}
