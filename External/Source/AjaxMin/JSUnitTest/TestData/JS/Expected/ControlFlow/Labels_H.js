function foo(){var c,e=0;a:for(var a=0;a<10;++a){c="";b:for(var d=0;d<a;++d){c=c+d+" ";continue b}if(a==8)break a;else if(a==4)continue a;b:for(var b=0;b<a;++b){if(b==10)break a;else if(b==7)continue b;c:d:while(e<b){e++;continue c}if(b==a)continue;else break}document.write("<div>"+c+a+"</div>")}}a: