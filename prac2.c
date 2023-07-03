#include <stdio.h>
#include <string.h>

int main(int argc, char *args[])
{
        printf("さかな博士「あなたの好きな魚はなんですか？」\n");

        char fish[255];
        scanf("%s", fish);

        if (strcmp(fish, "サバ") == 0) {
                printf("さかな博士「結婚してください。」\n");
        } else if (strcmp(fish, "うなぎ") == 0) {
                printf("うなぎ将軍「よくも俺の仲間を！！」\n");
        } else {
                printf("さかな博士「%s…ですか。私はサバのほうが美味しいと思いますがね。では。」\n", fish);
        }

        return 0;
}
