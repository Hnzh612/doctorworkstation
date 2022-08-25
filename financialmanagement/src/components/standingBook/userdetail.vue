<template>
  <div v-if="this.$type == '管理员'">
    <div class="searchmean" style="margin-bottom: 10px;">
      <el-button type="warning" icon="el-icon-check" circle @click="save()">保存</el-button>
      <el-button type="danger" icon="el-icon-delete" circle @click="dedeleteSalesOrder(curid)">删除</el-button>
      <el-button type="primary" icon="el-icon-upload el-icon--right" circle @click="exportExcel">导出</el-button>
      <el-button type="info" icon="el-icon-arrow-left" circle @click="back()">返回</el-button>
    </div>
    <div class="footer">
      <div class="line">
        <div class="row">
          <i>姓名：</i>
          <el-input v-model="userinfomation.name" class="input"></el-input>
        </div>
        <div class="row">
          <i>性别：</i>
          <el-input v-model="userinfomation.sex" class="input"></el-input>
        </div>
      </div>
      <div class="line">
        <div class="row">
          <i>身高：(CM)</i>
          <el-input v-model="userinfomation.height" class="input"></el-input>
        </div>
        <div class="row">
          <i>体重：(KG)</i>
          <el-input v-model="userinfomation.weight" class="input"></el-input>
        </div>
      </div>
      <div class="line">
        <div class="row">
          <i>糖尿病：</i>
          <el-input v-model="userinfomation.diabetes" class="input"></el-input>
        </div>
        <div class="row">
          <i>酗酒：</i>
          <el-input v-model="userinfomation.alcoholism" class="input"></el-input>
        </div>
      </div>
      <div class="line">
        <div class="row">
          <i>吸烟：</i>
          <el-input v-model="userinfomation.smoke" class="input"></el-input>
        </div>
        <div class="row">
          <i>电话：</i>
          <el-input v-model="userinfomation.phone" class="input"></el-input>
        </div>
      </div>
    </div>
    <el-table :data="tableData" style="width: 720px;"  tooltip-effect="dark"
      @selection-change="handleSelectionChange" id="sales">
      <el-table-column type="selection" width="55">
      </el-table-column>
      <el-table-column label="仪器测量数据" align="center">
        <el-table-column prop="date" label="日期" width="155" align="center">
        </el-table-column>
        <el-table-column prop="deviceName" label="设备名" width="100" align="center">
        </el-table-column>
        <el-table-column prop="systolicPressure" label="高压" width="100" align="center">
        </el-table-column>
        <el-table-column prop="diastolicPressure" label="低压" width="100" align="center">
        </el-table-column>
        <el-table-column prop="heartRate" label="心率" width="120" align="center">
        </el-table-column>
        <el-table-column prop="steps" label="运动步数" width="90" align="center">
        </el-table-column>
      </el-table-column>
    </el-table>
  </div>
  <notype v-else></notype>
</template>


<script>
import pages from '@/components/utlis/pages.vue'
import FileSaver from 'file-saver'
import XLSX from 'xlsx'
import notype from '@/components/utlis/notype.vue'
import userApi from '@/api/userApi'

export default {
  components: { pages,notype },
  name: 'userdetail',
  props: ['uid'],
  data() {
    return {
      show: false,
      curid: 0,
      varietys: [], // 品种
      Materials: [], // 材质
      cities: [], // 
      // 表格展示数据
      tableData: [],
      // 患者信息
      userinfomation: {

      },
      // 缓存数据
      temdata: {
        id: 0,
        date: '',
        variety: '',
        Material: '',
        city: '',
        specifications: '',
        weight: '',
        unitprice: '',
        amount: ''
      },
      // 查询体
      querybody: {
        rid:0,
        page:1,
        sname: "",
        scompany: "",
        rname: "",
        rcompany: ""
      },
    }
  },
  methods: {
    back() {
      this.$router.go(-1)
    },
    // 获取选中行
    handleSelectionChange(val) {
      this.multipleSelection = val;
      if (val.length > 0) {
        this.curid = val[0].id
      } else {
        this.curid = 0
      }

    },
    // 获取患者信息
    async GetUserById(uid) {
      const { data: res } = await userApi.GetUserById(uid)
      res.diabetes?res.diabetes='是':res.diabetes='否'
      res.alcoholism?res.alcoholism='是':res.alcoholism='否'
      res.smoke?res.smoke='是':res.smoke='否'
      this.userinfomation = res
    },
    // 获取仪器数据
    async GetHealthDate(uid) {
      const { data:res } = await userApi.GetHealthDate(uid)
      this.tableData = res
    },
    // 删除选中行
    async dedeleteSalesOrder(curid) {
            this.$confirm('此操作将永久删除该订单，是否继续？', '提示', {
        confirmButtonText: '确定',
        cancelButtonText: '取消',
        type: 'warning'
      }).then( async () => {
        const { data: res } = await salesApi.deleteSalesOrder(curid)
        if (res == 1) {
          this.$message({
            message: '删除成功',
            type: 'success'
          })
          this.getAllSalesOrder(this.cid)
        } else {
          this.$message({
            message: '删除失败',
            type: 'success'
          })
        }
      }).catch(()=>{
          this.$message({
            message: '已取消删除',
            type: 'info'
          })
      })
    },
    // 导出Excel表格
    exportExcel() {
      var wb = XLSX.utils.table_to_book(document.querySelector("#sales"))
      var wbout = XLSX.write(wb,{
        bookType: 'xlsx',
        bookSST: true,
        type: 'array'
      })
      try {
        FileSaver.saveAs(
          new Blob([wbout],{ type: "application/octet-stream" }),
          `${this.tableData[0].date.slice(0,7)}-销售详情.xlsx`
        )
      } catch (e) {
        if (typeof console !== 'undefined') console.log(e,wbout)
      }
      return wbout
    } 
  },
  mounted() {
    this.GetUserById(this.uid)
    this.GetHealthDate(this.uid)
  }
  ,
  updated() {
    for (let i = 0; i < this.tableData.length; i++) {
      this.$set(
        this.tableData[i], 'date', this.dayjs(this.tableData[i].date).format("YYYY-MM-DD")
      )
    }
  },
}
</script>

<style lang="less" scoped>
.demonstration {
  width: 100px;
  display: inline-block;
}

.inline-block {
  margin-bottom: 5px;
  height: 40px;
}

.footer {
  width: 720px;
  background-color: #F5F7FA;

  .row {
    display: inline-block;
    width: 50%;
    border: 1px solid #ebeef5;
  }

  i {
    margin-left: 5%;
    width: 30%;
  }

  .input {
    width: 50%;
  }

  .input/deep/.el-input__inner {
    background-color: #f5f7fa;
    border: 0;
  }

}
</style>