import { Component, OnInit, Input } from '@angular/core';
import { UserimageServiceService } from './../../services/userimage/userimage-service.service'

@Component({
  selector: 'app-view-cv-userimage',
  templateUrl: './view-cv-userimage.component.html',
  styleUrls: ['./view-cv-userimage.component.css']
})
export class ViewCvUserimageComponent implements OnInit {

    @Input() userImagePath:string;

  constructor() { }

  ngOnInit() {
   
  }

}
