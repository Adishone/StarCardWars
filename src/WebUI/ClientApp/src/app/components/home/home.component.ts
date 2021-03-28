import { Component } from '@angular/core';
import { CrewMemberFightResult } from 'src/app/models/crew-member-fight-result.model';
import { CrewMember } from 'src/app/models/crew-member.model';
import { StarshipFightResult } from 'src/app/models/starship-fight-result.model';
import { Starship } from 'src/app/models/starship.model';
import { CrewMemberService } from 'src/app/services/crew-member.service';
import { StarshipService } from 'src/app/services/starship.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent {
  public isLoading = false;
  public fightType = "";
  public starshipFightResult: StarshipFightResult;
  public crewMemberFightResult: CrewMemberFightResult;

  constructor(private starshipService: StarshipService, private crewMemberService: CrewMemberService) {
  }

  public onStarshipFightClick(): void
  {
    this.isLoading = true;
    this.fightType = "Starship";
    this.starshipService.getStarshipFightResult().subscribe(result => { 
      this.starshipFightResult = result.data;
      this.isLoading = false; })
  }

  public onCrewMemberFightClick(): void
  {
    this.isLoading = true;
    this.fightType = "CrewMember";
    this.crewMemberService.getCrewMembersFightResult().subscribe(result => { 
      this.crewMemberFightResult = result.data;
      this.isLoading = false; })
  }
}
