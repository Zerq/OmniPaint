import { Component } from '@angular/core';
import * as Tone from 'tone';
import { Midi } from '@tonejs/midi';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'tonejs';

  run() {

    //const song = require("./creepyForest.json");


    Midi.fromUrl("./creepyForest.json").then(m => { });



   // let data = JSON.parse(song);
    


    const synth = new Tone.PolySynth(Tone.Synth).toDestination();
    const now = Tone.now()
    synth.triggerAttackRelease("D4", now)
    synth.triggerAttackRelease("F4", now + 0.5);
    synth.triggerAttackRelease("A4", now + 1);
    synth.triggerAttackRelease("C5", now + 1.5);
    synth.triggerAttackRelease("E5", now + 2);

    synth.triggerRelease(["D4", "F4", "A4", "C5", "E5"], now + 4);

  }

  ngOnInit(): void {


  }

}
