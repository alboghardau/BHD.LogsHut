import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { ButtonModule } from 'primeng/button';
import { TableModule } from 'primeng/table';
import { OptionsBarComponent } from './components/options-bar/options-bar.component';
import { LogsTableComponent } from './components/logs-table/logs-table.component';
import { HttpClient, HttpClientModule } from '@angular/common/http';

@NgModule({
  declarations: [AppComponent, OptionsBarComponent, LogsTableComponent],
  imports: [BrowserModule, ButtonModule, TableModule, HttpClientModule],
  providers: [],
  bootstrap: [AppComponent],
})
export class AppModule {}
