// import { Component } from '@angular/core';
// import { ChatgptService } from 'src/app/services/chatgpt.service';
// import { HttpClient } from '@angular/common/http';
// @Component({
//   selector: 'app-chat',
//   templateUrl: './chat.component.html',
//   styleUrls: ['./chat.component.css']
// })
// export class ChatComponent {
//   constructor(private gpt: ChatgptService, private http: HttpClient) {

//   }
//   input = ''
//   response: any
//   getResponse(input: string) {
//     console.log(input, "started")
//     this.gpt.getResponse(input, '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').subscribe(res => {
//       this.response = res;
//       console.log("gpt", res)
//     })
//   }

// }
// chat.component.ts
import { Component, OnInit } from '@angular/core';
import { ChatgptService } from 'src/app/services/chatgpt.service';
import { Msg } from 'src/app/Interfaces/msg';
@Component({
  selector: 'app-chat',
  templateUrl: './chat.component.html',
  styleUrls: ['./chat.component.css']
})
export class ChatComponent implements OnInit {
  userMessage = '';
  response = '';
  myArray: Msg[] = [];
  loading: boolean = false

  constructor(private chatgptService: ChatgptService) { }

  async sendMessage() {
    this.loading = true
    this.response = await this.chatgptService.createCompletion(this.userMessage, 512, .1,);
    this.loading = false
    this.myArray.push({ userMessage: this.userMessage, response: this.response })
    this.response = ''
    this.userMessage = ''
  }

  ngOnInit() { }
}
