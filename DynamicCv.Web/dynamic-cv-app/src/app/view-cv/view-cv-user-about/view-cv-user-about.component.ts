import { Component, OnInit, Input } from '@angular/core';


@Component({
  selector: 'app-view-cv-user-about',
  templateUrl: './view-cv-user-about.component.html',
  styleUrls: ['./view-cv-user-about.component.css']
})
export class ViewCvUserAboutComponent implements OnInit {
  @Input() aboutText:string;
  constructor() { }

  ngOnInit() {
  }

}
