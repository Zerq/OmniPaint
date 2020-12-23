import { __decorate } from "tslib";
import { Component } from '@angular/core';
import * as Tone from 'tone';

let AppComponent = class AppComponent {
    constructor() {
        this.title = 'tonejs';
    }
  run() {

 

        const synth = new Tone.PolySynth(Tone.Synth).toDestination();
        const now = Tone.now();
        synth.triggerAttackRelease("D4", now);
        synth.triggerAttackRelease("F4", now + 0.5);
        synth.triggerAttackRelease("A4", now + 1);
        synth.triggerAttackRelease("C5", now + 1.5);
        synth.triggerAttackRelease("E5", now + 2);
        synth.triggerRelease(["D4", "F4", "A4", "C5", "E5"], now + 4);
    }
    ngOnInit() {
    }
};
AppComponent = __decorate([
    Component({
        selector: 'app-root',
        templateUrl: './app.component.html',
        styleUrls: ['./app.component.css']
    })
], AppComponent);
export { AppComponent };
//# sourceMappingURL=app.component.js.map
