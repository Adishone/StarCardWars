import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Score } from '../models/score.model';

@Injectable({
  providedIn: 'root'
})
export class ScoreService {

  constructor(private httpClient: HttpClient) { }

  public getScore(): Observable<Score> {
    return this.httpClient.get<Score>('https://localhost:44312/api/score');
  }
}
