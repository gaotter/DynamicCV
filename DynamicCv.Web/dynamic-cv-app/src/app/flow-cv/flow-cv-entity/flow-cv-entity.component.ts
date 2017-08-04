import { Component, OnInit, Input } from '@angular/core';
import { IEntries } from './../../interfaces/i-entires';

@Component({
  selector: 'app-flow-cv-entity',
  templateUrl: './flow-cv-entity.component.html',
  styleUrls: ['./flow-cv-entity.component.css']
})
export class FlowCvEntityComponent implements OnInit {
  @Input() entry:IEntries;
  editMode:boolean = false;
  constructor() { }

  toogleEditMode() {
    this.editMode = !this.editMode;
  }

  ngOnInit() {
  }

}
