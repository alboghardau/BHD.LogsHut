import { Injectable } from "@angular/core";
import { Log } from "../models/log";

@Injectable({
    providedIn: "root",
})
export class LogsService {
    private logs: Log[] = [];

    constructor() {}

    public getAllLogs(): Log[] {
        return this.logs;
    }

    public addLog(log: Log): void {
        this.logs.push(log);
    }

    public clearLogs(): void {
        this.logs = [];
    }
}
