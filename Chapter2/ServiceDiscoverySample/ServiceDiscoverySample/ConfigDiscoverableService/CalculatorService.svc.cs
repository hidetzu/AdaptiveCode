using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

using ServiceContract;

namespace ConfigDiscoverableService
{
    // メモ: [リファクター] メニューの [名前の変更] コマンドを使用すると、コード、svc、および config ファイルで同時にクラス名 "CalculatorService" を変更できます。
    // 注意: このサービスをテストするために WCF テスト クライアントを起動するには、ソリューション エクスプローラーで CalculatorService.svc または CalculatorService.svc.cs を選択し、デバッグを開始してください。
    public class CalculatorService : ServiceContract.CalculatorService
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
    }
}
