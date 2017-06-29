import { Component, OnInit, Input } from '@angular/core';


@Component({
  selector: 'app-cv-user-about',
  templateUrl: './cv-user-about.component.html',
  styleUrls: ['./cv-user-about.component.css']
})
export class CvUserAboutComponent implements OnInit {
  @Input() aboutText:string;
  constructor() { }

  ngOnInit() {
  }

}
