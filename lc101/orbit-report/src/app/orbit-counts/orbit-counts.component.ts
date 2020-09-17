import { Component, OnInit, Input } from '@angular/core';
import { Satellite } from '../satellite';

@Component({
  selector: 'app-orbit-counts',
  templateUrl: './orbit-counts.component.html',
  styleUrls: ['./orbit-counts.component.css']
})
export class OrbitCountsComponent implements OnInit {
  @Input() satellites: Satellite[];
  constructor() {
   }

  ngOnInit() {
  }

  get getTotalCount(): number{
    let map = this.getTotalOrbitCount();
    let counter = 0;
    for (let value of map)
      counter+=value[1];
      // alert(counter)
    return counter;
  }

  getTotalOrbitCount(){
    let map = new Map();
    let satelliteList: Satellite[]=this.satellites;
    for(let i:number=0; i < this.satellites.length; i++){
      if (map.has(this.satellites[i].type)){
        map.set(this.satellites[i].type, map.get(this.satellites[i].type)+1);  
      } else {
        map.set(this.satellites[i].type, 1);
      }
    }
    return map;
  }
    
}
