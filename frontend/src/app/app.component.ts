import { AfterViewInit, Component, OnInit } from '@angular/core';
import { RouterModule, RouterOutlet } from '@angular/router';
import { NgxParticlesComponent, NgxParticlesModule } from '@tsparticles/angular';
import { ISourceOptions } from '@tsparticles/engine';
import { loadSlim } from '@tsparticles/slim';

@Component({
  selector: 'app-root',
  imports: [RouterOutlet, RouterModule, NgxParticlesModule],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent implements OnInit  {

  isAudioPlaying = true;
  audioEl!: HTMLAudioElement;

  ngOnInit(): void {
    this.audioEl = document.querySelector('audio') as HTMLAudioElement;    
    this.audioEl.volume = 0.04; // Sets volume to 20%
    this.audioEl.loop = true;
  }

  toggleAudio() {
    if (this.audioEl) {
      if (this.isAudioPlaying) {
        this.audioEl.pause();
      } else {
        this.audioEl.play();
      }
      this.isAudioPlaying = !this.isAudioPlaying;
    }
  }

  particlesOptions: ISourceOptions = {
    background: {
      color: {
        value: '#0b0c10'
      }
    },
    fpsLimit: 60,
    particles: {
      color: {
        value: '#ff6600'
      },
      links: {
        enable: true,
        color: '#ff6600',
        distance: 150,
        opacity: 0.3,
        width: 1
      },
      move: {
        enable: true,
        speed: 1,
        outModes: {
          default: 'bounce'
        }
      },
      number: {
        value: 50,
        density: {
          enable: true
        }
      },
      shape: {
        type: 'circle'
      },
      size: {
        value: { min: 1, max: 4 }
      }
    },
    detectRetina: true
  };

  async particlesInit(engine: any): Promise<void> {
    await loadSlim(engine);
  }

}
