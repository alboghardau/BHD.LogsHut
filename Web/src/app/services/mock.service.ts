import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root',
})
export class MockService {
  constructor(private httpClient: HttpClient) {}

  public startMock() {
    this.httpClient
      .post('https://localhost:7267/api/mock/StartMock/', '')
      .subscribe((response) => {});
  }

  public stopMock() {
    this.httpClient
      .post('https://localhost:7267/api/mock/StopMock', '')
      .subscribe((response) => {});
  }
}
