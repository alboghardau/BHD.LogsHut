import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { ButtonModule } from 'primeng/button';
import { OptionsBarComponent } from './components/options-bar/options-bar.component';

@NgModule({
  declarations: [AppComponent, OptionsBarComponent],
  imports: [BrowserModule, ButtonModule],
  providers: [],
  bootstrap: [AppComponent],
})
export class AppModule {}
