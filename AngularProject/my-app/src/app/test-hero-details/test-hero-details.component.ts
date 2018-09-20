import { Component, OnInit, Input, EventEmitter, Output } from '@angular/core';
import { Hero } from '../hero';

@Component({
  selector: 'app-test-hero-details',
  templateUrl: './test-hero-details.component.html',
  styleUrls: ['./test-hero-details.component.css']
})
export class TestHeroDetailsComponent implements OnInit {

  @Input() hero:Hero;
  @Output() deleteEvent = new EventEmitter<Hero>();
  constructor() { }

  ngOnInit() {
  }

  delete(hero:Hero):void{
    this.deleteEvent.emit(hero);
  }

}
