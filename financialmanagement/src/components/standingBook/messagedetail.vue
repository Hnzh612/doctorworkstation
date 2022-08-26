<template>
    <div>
        <div class="chat_save">
            <el-row v-for="message in messages" :key="message.sid">
                <div v-if="message.sid==user1.id">
                    <el-col :span="1">
                        <el-image class="pic"  :src="require('@/assets/pic_boy.png')" v-if="user1.sex == '男'"></el-image>
                        <el-image  class="pic"  :src="require('@/assets/pic_girl.jpg')" v-else-if="user1.sex == '女'"></el-image>
                    </el-col>
                    <div class="msg_1">
                        <el-col :span="10" ><div class="msg_2">{{   message.msg     }}</div></el-col>
                    </div>
                    
                </div>
                <div v-else-if="message.sid==user2.id" class="right">
                    <el-col :span="1">
                        <el-image class="pic_1"  :src="require('@/assets/pic_boy.png')" v-if="user2.sex == '男'"></el-image>
                        <el-image  class="pic_1"  :src="require('@/assets/pic_girl.jpg')" v-else-if="user2.sex == '女'"></el-image>
                    </el-col>
                </div>
            </el-row>
        </div>
        <div class="chat_input">
            <el-input v-model="input" class=""></el-input>
        </div>
    </div>
</template>

<style scoped>
    .right{
        position: absolute;
        right: 20px;
    }
    .msg_1{
        padding-left: 85px;
        padding-top:15px;
    }
    .msg_2{
        border: solid 1px;
        border-radius: 10px;
        line-height: 23px;
        padding-right: 5px;
        padding-left: 5px;
    }
    .pic{
        width: 70px;
        height: 50px;
        padding-left: 20px;
    }
    .pic_1{
        width: 70px;
        height: 50px;
        padding-right: 20px;
    }
    .chat_save{
        height: 500px;
        background-color: rgb(250, 250, 250);
    }

    .chat_input{
        height: 140px;
        border-top: solid 1px;
        background-color: rgb(250, 250, 250);
    }
</style>

<script>
export default {
    data(){
        return{
            input: '',
            user1: {
                id: 1,
                sex: '男'
            },
            user2: {
                id: 2,
                sex: '男'
            },
            messages: [{
                sid: 1,
                rid:2,
                msg: "你好对马克思的看是打算看到你的说法都是发发士大夫打发打发打发发三点你觉得那大撒大撒大苏打是刷卡当年卡刷你的卡撒"
            },
            {
                sid: 2,
                rid:1,
                msg: "你好"
            },
            {
                sid: 1,
                rid:2,
                msg: "你好"
            },
            {
                sid: 1,
                rid:2,
                msg: "你好"
            },
            {
                sid: 2,
                rid:1,
                msg: "你好"
            },]

        }
    }
}
</script>