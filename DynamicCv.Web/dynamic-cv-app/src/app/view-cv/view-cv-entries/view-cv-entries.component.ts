import { Component, OnInit, Input } from '@angular/core';
import {IEntries} from './../../interfaces/i-entires';

@Component({
  selector: 'app-view-cv-entries',
  templateUrl: './view-cv-entries.component.html',
  styleUrls: ['./view-cv-entries.component.css']
})
export class ViewCvEntriesComponent implements OnInit {
  @Input() enties:IEntries[]
  _enties:IEntries[]

  constructor() { }

  ngOnInit() {
    this._enties = this.enties || [];
  }

}
