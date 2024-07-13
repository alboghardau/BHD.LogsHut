import { APP_INITIALIZER, NgModule } from "@angular/core";
import { BrowserModule } from "@angular/platform-browser";
import { AppComponent } from "./app.component";
import { HttpClient, HttpClientModule } from "@angular/common/http";
import { ConfigurationService } from "./services/configuration.service";
import { AppRoutingModule } from "./app-routing.module";
import { AppLayoutModule } from "./components/layout/app.layout.module";
import { TableModule } from "primeng/table";

export function initConfiguration(service: ConfigurationService) {
    return (): Promise<any> => {
        return service.loadConfig();
    };
}
@NgModule({
    declarations: [AppComponent],
    imports: [AppRoutingModule, AppLayoutModule],
    providers: [
        {
            provide: APP_INITIALIZER,
            useFactory: initConfiguration,
            deps: [ConfigurationService],
            multi: true,
        },
    ],
    bootstrap: [AppComponent],
})
export class AppModule {}
