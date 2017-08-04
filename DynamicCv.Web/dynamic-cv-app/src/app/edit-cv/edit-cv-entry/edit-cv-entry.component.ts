import { Component, OnInit, Input } from '@angular/core';
import { IEntries } from './../../interfaces/i-entires';
import { DateTimeService } from './../../services/helpers/date-time.service';

@Component({
  selector: 'app-edit-cv-entry',
  templateUrl: './edit-cv-entry.component.html',
  styleUrls: ['./edit-cv-entry.component.css']
})
export class EditCvEntryComponent implements OnInit {
  @Input() entry: IEntries;
  entryModel: IEntries;
  constructor(private dateTimeService: DateTimeService) { }

  onFromModelChange(ev: string) {
    if(!(Date.parse(ev))) return;
    let ticks = this.dateTimeService.toTicks(ev);
    this.entry.from = ev;
    this.entry.fromAsUtcJsTicks = ticks;
  }

  onToModelChange(ev: string) {
    if(!(Date.parse(ev))) return;
    let ticks = this.dateTimeService.toTicks(ev);
    this.entry.to = ev;
    this.entry.toAsUtcJSTicks = ticks;
  }

  ngOnInit() {
    this.entryModel = {
      areas: null,
      contentText: "test",
      from: null,
      id: 1,
      title: "test",
      to: null,
      projects: null,
      fromAsUtcJsTicks: null,
      toAsUtcJSTicks: null
    }
  }

}
