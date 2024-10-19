import { AfterViewInit, Component, ElementRef, HostListener, ViewChild } from "@angular/core";
import { MenuItem } from "primeng/api";
import { LayoutService } from "./service/app.layout.service";
import { TransferService } from "src/app/services/transfer.service";

@Component({
    selector: "app-topbar",
    templateUrl: "./app.topbar.component.html",
})
export class AppTopBarComponent implements AfterViewInit {
    items!: MenuItem[];
    isScreenSmall: boolean = false;

    @ViewChild("menubutton") menuButton!: ElementRef;
    @ViewChild("topbarmenubutton") topbarMenuButton!: ElementRef;
    @ViewChild("topbarmenu") menu!: ElementRef;

    constructor(
        public layoutService: LayoutService,
        public transferService: TransferService
    ) { }

    ngAfterViewInit() {
        // Initialize the screen size check after view is initialized
        this.checkScreenSize();
    }

    @HostListener('window:resize', ['$event'])
    onResize(event: Event) {
        // Update the boolean when the window is resized
        this.checkScreenSize();
    }

    checkScreenSize() {
        this.isScreenSmall = window.innerWidth < 990;
    }
}