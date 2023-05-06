import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { ButtonModule } from 'primeng/button';
import { TableModule } from 'primeng/table';
import { OptionsBarComponent } from './components/options-bar/options-bar.component';
import { LogsTableComponent } from './components/logs-table/logs-table.component';

@NgModule({
  declarations: [AppComponent, OptionsBarComponent, LogsTableComponent],
  imports: [BrowserModule, ButtonModule, TableModule],
  providers: [],
  bootstrap: [AppComponent],
})
export class AppModule {}
