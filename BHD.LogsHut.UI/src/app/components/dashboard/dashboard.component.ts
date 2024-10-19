import { Component, OnInit } from "@angular/core";
import { ChartData, ChartOptions } from "chart.js";
import { StatisticsService } from "src/app/data-access/statistics.service";
import { LineChartData } from "../shared/charts/line-chart/line-chart-data.model";
import { LogsDataService } from "src/app/data-access/logs-data.service";
import { Log } from "src/app/models/log.model";
import { EMPTY, Subscription, switchMap, timer } from "rxjs";

@Component({
    selector: "dashboard-component",
    templateUrl: "./dashboard.component.html",
})
export class DashboardComponent implements OnInit {
    public chartData: LineChartData | undefined;
    public lastCriticalLogs: Log[] = [];

    private dataSubscription?: Subscription;

    constructor(private statsService: StatisticsService, private logsService: LogsDataService) { }

    ngOnInit(): void {

        this.dataSubscription = timer(0, 5000)
            .pipe(
                switchMap(() => {
                    this.readData();
                    return EMPTY;
                })
            )
            .subscribe(() => { });
    }

    private readData() {
        //chart data
        this.statsService.getLastHourStats().subscribe((data: LineChartData) => {
            this.chartData = data;
        });

        //table data
        this.logsService.getLastCritical().subscribe((data: Log[]) => {
            this.lastCriticalLogs = data;
        })
    }
}
