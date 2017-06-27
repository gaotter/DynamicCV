import { Component, OnInit } from '@angular/core';
import { Http } from '@angular/http'

@Component({
  selector: 'app-test-service-call',
  templateUrl: './test-service-call.component.html',
  styleUrls: ['./test-service-call.component.css']
})
export class TestServiceCallComponent implements OnInit {

  constructor(private _httpService: Http) { }

  testApiValues: string[] = []

  ngOnInit() {
    this._httpService.get('/api/values').subscribe(v => this.testApiValues = v.json() as string []);
  }

}
