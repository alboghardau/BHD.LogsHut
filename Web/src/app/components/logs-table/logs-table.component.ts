import { Component, OnInit } from '@angular/core';
import { Log } from 'src/app/models/Log';

@Component({
  selector: 'logs-table',
  templateUrl: './logs-table.component.html',
  styleUrls: ['./logs-table.component.scss'],
})
export class LogsTableComponent implements OnInit {
  constructor() {}

  public tableSize: string = 'p-datatable-sm';

  public logs: Log[] = [
    {
      time: new Date('2023-05-07T18:59:11.80606Z'),
      message: 'Found 10 matching results for search query ',
    },
  ];

  ngOnInit(): void {}
}
