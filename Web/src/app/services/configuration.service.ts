import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";

@Injectable({
    providedIn: "root",
})
export class ConfigurationService {
    private config: any;

    constructor(private http: HttpClient) {}

    load() {
        this.http.get("app.config.json").subscribe((response) => {
            this.config = response;
            console.log("Config Service: Loaded config");
        });
    }

    get baseUrl(): string {
        return this.config.baseUrl;
    }
}
