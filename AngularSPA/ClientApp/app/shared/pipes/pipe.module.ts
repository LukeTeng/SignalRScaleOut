import { NgModule } from '@angular/core';
import { SystemTextPipe } from './systemText.pipe';
import { SafeHtmlPipe } from './safe-html.pipe';
import Highlightpipe = require("./highlight.pipe");
import HighlightPipe = Highlightpipe.HighlightPipe;

@NgModule({
    declarations: [
      SystemTextPipe,
      SafeHtmlPipe,
      HighlightPipe
    ],
    exports: [
        SystemTextPipe,
      SafeHtmlPipe,
      HighlightPipe
    ]
})

export class PipeModule{}
