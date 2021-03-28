import { Component, OnInit } from '@angular/core';
import { CrewMemberFightResult } from 'src/app/models/crew-member-fight-result.model';
import { CrewMember } from 'src/app/models/crew-member.model';
import { StarshipFightResult } from 'src/app/models/starship-fight-result.model';
import { Starship } from 'src/app/models/starship.model';
import { CrewMemberService } from 'src/app/services/crew-member.service';
import { ScoreService } from 'src/app/services/score.service';
import { StarshipService } from 'src/app/services/starship.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent implements OnInit {
  public isLoading = false;
  public fightType = "";
  public starshipFightResult: StarshipFightResult;
  public crewMemberFightResult: CrewMemberFightResult;
  public firstPlayerScore: number;
  public secondPlayerScore: number;

  constructor(private starshipService: StarshipService, 
    private crewMemberService: CrewMemberService,
    private scoreService: ScoreService) {
  }

  ngOnInit(): void {
    this.scoreService.getScore().subscribe(result => {
      this.firstPlayerScore = result.firstPlayerWins;
      this.secondPlayerScore = result.secondPlayerWins;
    })
  }

  public onStarshipFightClick(): void
  {
    this.crewMemberFightResult = null;
    this.isLoading = true;
    this.fightType = "Starship";
    this.starshipService.getStarshipFightResult().subscribe(result => { 
      this.starshipFightResult = result;
      this.isLoading = false;
      this.firstPlayerScore = this.starshipFightResult.firstPlayerOverallScore;
      this.secondPlayerScore = this.starshipFightResult.secondPlayerOverallScore; })
  }

  public onCrewMemberFightClick(): void
  {
    this.starshipFightResult = null;
    this.isLoading = true;
    this.fightType = "CrewMember";
    this.crewMemberService.getCrewMembersFightResult().subscribe(result => { 
      this.crewMemberFightResult = result;
      this.isLoading = false;
      this.firstPlayerScore = this.crewMemberFightResult.firstPlayerOverallScore;
      this.secondPlayerScore = this.crewMemberFightResult.secondPlayerOverallScore;
     })
  }
}
