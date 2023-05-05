// import { Injectable } from '@angular/core';
// import { HttpClient, HttpHeaders } from '@angular/common/http';
// import { Observable } from 'rxjs';

// @Injectable({
//   providedIn: 'root'
// })
// export class ChatgptService {
//   constructor(private http: HttpClient) { }

//   getResponse(input: string, apiKey: string): Observable<any> {
//     const headers = new HttpHeaders({
//       'Content-Type': 'application/json',
//       'Authorization': `Bearer ${apiKey}`
//     });

//     return this.http.post(
//       'https://api.openai.com/v1/compleation',
//       {
//         prompt: input,
//         max_tokens: 100,
//         temperature: 0.5,
//       },
//       { headers }
//     );
//   }
// }
// chatgpt.service.ts
import { Injectable } from '@angular/core';
import { Configuration, OpenAIApi } from 'openai';

@Injectable({
  providedIn: 'root'
})
export class ChatgptService {
  private configuration = new Configuration({
    apiKey: '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',
  });
  private openai = new OpenAIApi(this.configuration);

  async createCompletion(prompt: string, maxTokens: number, temperature: number,): Promise<string> {
    const response = await this.openai.createCompletion({
      model: 'text-davinci-003',
      prompt,
      max_tokens: maxTokens,
      temperature,
    });
    const text = response.data.choices[0].text;
    return text ? text : "No completion available";
  }
}
