import { Component, ElementRef, ViewChild } from '@angular/core';
import { Square } from './square';
import * as Tone from 'tone';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'Omnipaint';

  @ViewChild('canvas', { static: true })
  canvas: ElementRef<HTMLCanvasElement>;

  private ctx: CanvasRenderingContext2D;

  ngOnInit(): void {
    this.ctx = this.canvas.nativeElement.getContext('2d');

    const synth = new Tone.Synth().toDestination();
    const now = Tone.now()
    synth.triggerAttackRelease("C4", "8n", now)
    synth.triggerAttackRelease("E4", "8n", now + 0.5)
    synth.triggerAttackRelease("G4", "8n", now + 1)
  }


  animate(): void {
    this.ctx.fillStyle = 'red';
    const square = new Square(this.ctx);
    square.draw(5, 1, 20);  
  }

}
