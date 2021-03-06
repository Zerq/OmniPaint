import { __decorate } from "tslib";
import { Component, ViewChild } from '@angular/core';
import { Square } from './square';
import * as Tone from 'tone';
let AppComponent = class AppComponent {
    constructor() {
        this.title = 'Omnipaint';
    }
    ngOnInit() {
        this.ctx = this.canvas.nativeElement.getContext('2d');
        const synth = new Tone.Synth().toDestination();
        const now = Tone.now();
        synth.triggerAttackRelease("C4", "8n", now);
        synth.triggerAttackRelease("E4", "8n", now + 0.5);
        synth.triggerAttackRelease("G4", "8n", now + 1);
    }
    animate() {
        this.ctx.fillStyle = 'red';
        const square = new Square(this.ctx);
        square.draw(5, 1, 20);
    }
};
__decorate([
    ViewChild('canvas', { static: true })
], AppComponent.prototype, "canvas", void 0);
AppComponent = __decorate([
    Component({
        selector: 'app-root',
        templateUrl: './app.component.html',
        styleUrls: ['./app.component.css']
    })
], AppComponent);
export { AppComponent };
//# sourceMappingURL=app.component.js.map